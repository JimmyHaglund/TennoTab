using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.ViewModels;
using WarframeProgressTrackerApi.Services;

namespace WarframeProgressTrackerApi.Controllers {
    [ApiController]
    [Route("[Controller]/[Action]")]
    [EnableCors]
    public class UserController : ControllerBase {
        private WarframeProgressTrackerContext _dataContext;
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;
        private SessionUser _sessionUser;
        private RoleManager<IdentityRole> _roleManager;
        private static bool _seeded = false;
        private const string ADMIN = "Administrator";
        private const string SYSADMIN = "SysAdm";

        public UserController(
            WarframeProgressTrackerContext databaseContext,
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            SessionUser sessionUser,
            RoleManager<IdentityRole> roleManager
            ) {
            _dataContext = databaseContext;
            _signInManager = signInManager;
            _userManager = userManager;
            _sessionUser = sessionUser;
            _roleManager = roleManager;
        }


        [HttpPost]
        public async Task<ActionResult<UserView>> Login(LoginInfo login) {
            await SeedAdmin();
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null) return BadRequest("Login failed: User not found.");

            var result = await _signInManager
                .PasswordSignInAsync(user, login.Password, true, false);
            if (!result.Succeeded) return BadRequest("Login failed: Password is incorrect.");
            
            var headers = Response.Headers;
            if (headers.TryGetValue("Set-Cookie", out var cookie)) {
                cookie = ExtractResponseCookie(cookie);
                _sessionUser.Add(cookie, user.Id);
            }

            return new UserView() { 
                Name = user.UserName, 
                IsAdmin = await IsAdmin(user)
            };
        }

        [HttpPost]
        public async Task<UserView> Register(LoginInfo login) {
            var user = new User() { UserName = login.UserName };
            var createUserResult = await _userManager.CreateAsync(user, login.Password);
            if (createUserResult.Succeeded) {
                _dataContext.CreateUserData(user.Id);
                return new UserView() {
                    Name = user.UserName,
                    IsAdmin = await IsAdmin(user)
                };
            }
            return new UserView();
        }

        [HttpGet]
        [Authorize(Roles = ADMIN)]
        public async Task<IEnumerable<UserView>> GetAll() {
            var users = _dataContext.Users.ToList();
            var userViews = new List<UserView>(users.Count);
            foreach (var user in users) {
                var isAdmin = await IsAdmin(user);
                userViews.Add(new UserView() {
                    Name = user.UserName,
                    IsAdmin = isAdmin
                });
            }
            return userViews;
        }

        [HttpPost]
        [Authorize(Roles = ADMIN)]
        public async Task<UserView> Set([FromBody] UserView userInfo) {
            var user = await _userManager.FindByNameAsync(userInfo.Name);
            var senderId = _sessionUser.IdFromRequest(Request);
            var sender = await _userManager.FindByIdAsync(senderId);
            if (user.Id == sender.Id) userInfo.IsAdmin = true;
            if (userInfo.IsAdmin) {
                await _userManager.AddToRoleAsync(user, ADMIN);
            } else {
                await _userManager.RemoveFromRoleAsync(user, ADMIN);
            }
            return new UserView() {
                Name = userInfo.Name,
                IsAdmin = userInfo.IsAdmin
            };
        }

        private async Task<bool> IsAdmin(User user) {
            return await _userManager.IsInRoleAsync(user, ADMIN);
        }

        private string ExtractResponseCookie(string cookieRaw) {
            var result = cookieRaw.Substring(cookieRaw.IndexOf("=") + 1);
            return result.Substring(0, result.IndexOf(";"));
        }

        private async Task SeedAdmin() {
            if (_seeded) return;

            var adminExists = await _roleManager.RoleExistsAsync(ADMIN);
            if (!adminExists) {
                await _roleManager.CreateAsync(new IdentityRole(ADMIN));
            }

            var user = await _userManager.FindByNameAsync(SYSADMIN);
            if (user == null) return;
            await _userManager.AddToRoleAsync(user, ADMIN);

            _seeded = true;
        }
    }
}
