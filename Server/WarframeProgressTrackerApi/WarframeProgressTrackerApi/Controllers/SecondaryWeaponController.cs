using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;

namespace WarframeProgressTrackerApi.Controllers {
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class SecondaryWeaponController : ControllerBase {

        private WarframeProgressTrackerContext _context;
        private SessionUser _sessionUser;

        public SecondaryWeaponController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        [HttpGet]
        [EnableCors]
        public IEnumerable<SecondaryWeapon> Get() {
            var requestCookies = Request.Cookies;
            if (requestCookies.TryGetValue("auth_cookie", out var cookie)) {
                var userId = _sessionUser.Get(cookie);
                if (userId != "null") {
                    return _context.SecondaryWeapons;
                }
            }
            return null;

            // return _context.SecondaryWeapons;
        }

        [HttpGet("{id:int}")]
        [EnableCors]
        public SecondaryWeapon Get(int id) {
            return _context.SecondaryWeapons.Find(id);
        }
    }
}
