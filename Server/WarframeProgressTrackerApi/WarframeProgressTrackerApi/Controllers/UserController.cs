using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.ViewModels;
using Microsoft.AspNetCore.Cors;
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

        public UserController(
            WarframeProgressTrackerContext databaseContext,
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            SessionUser sessionUser) {
            _dataContext = databaseContext;
            _signInManager = signInManager;
            _userManager = userManager;
            _sessionUser = sessionUser;
        }


        [HttpPost]
        public async Task<UserView> Login(LoginInfo login) {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null) return null;

            var result = await _signInManager
                .PasswordSignInAsync(user, login.Password, true, false);
            if (!result.Succeeded) return null;
            
            var headers = Response.Headers;
            if (headers.TryGetValue("Set-Cookie", out var cookie)) {
                cookie = ExtractResponseCookie(cookie);
                _sessionUser.Add(cookie, user.Id);
            }

            var userRoles = _dataContext.UserRoles.Where(userRole => userRole.UserId == user.Id);
            return new UserView() { }
        }

        private string ExtractResponseCookie(string cookieRaw) {
            var result = cookieRaw.Substring(cookieRaw.IndexOf("=") + 1);
            return result.Substring(0, result.IndexOf(";"));
        }

        [HttpPost]
        public async Task<User> Register(LoginInfo login) {
            var user = new User() { UserName = login.UserName };
            var createUserResult = await _userManager.CreateAsync(user, login.Password);
            if (createUserResult.Succeeded) {
                _dataContext.CreateUserData(user.Id);
                return user;
            }
            return null;
        }


    }
}
