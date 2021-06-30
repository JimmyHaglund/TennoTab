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
    [Route("[Controller]")]
    [EnableCors]
    public class UserController : ControllerBase {
        private WarframeProgressTrackerContext _dataContext;
        private SignInManager<User> _signInManager;

        public UserController(
            WarframeProgressTrackerContext databaseContext,
            SignInManager<User> signInManager) {
            _dataContext = databaseContext;
            _signInManager = signInManager;
        }


        [HttpPost]
        [AllowAnonymous]
        public Frame Post(Login login) {
            return _dataContext.Frames.FirstOrDefault();
            /*
            var result = await _signInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);
            if (result.Succeeded) {
                return "OK";
            }
            return "NO";
            */
        }
    }
}
