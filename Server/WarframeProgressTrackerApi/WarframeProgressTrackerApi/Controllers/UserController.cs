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
using Microsoft.AspNetCore.Cors;

namespace WarframeProgressTrackerApi.Controllers {
    [ApiController]
    [Route("[Controller]/[Action]")]
    [EnableCors]
    public class UserController : ControllerBase {
        private WarframeProgressTrackerContext _dataContext;
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        public UserController(
            WarframeProgressTrackerContext databaseContext,
            SignInManager<User> signInManager,
            UserManager<User> userManager) {
            _dataContext = databaseContext;
            _signInManager = signInManager;
            _userManager = userManager;
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login(Login login) {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null) return null;
            var result = await _signInManager
                .PasswordSignInAsync(user, login.Password, false, false);
            return result;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IdentityResult> Register(Login login) {
            var user = new User() { UserName = login.UserName };
            var createUserResult = await _userManager.CreateAsync(user, login.Password);
            // return _dataContext.Frames.FirstOrDefault();
            return createUserResult;
        }


    }
}
