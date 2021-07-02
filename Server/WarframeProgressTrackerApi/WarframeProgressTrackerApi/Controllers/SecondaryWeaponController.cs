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

namespace WarframeProgressTrackerApi.Controllers {
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class SecondaryWeaponController : ControllerBase {
        public SecondaryWeaponController(WarframeProgressTrackerContext context) =>
            _context = context;

        private WarframeProgressTrackerContext _context;

        [HttpGet]
        [EnableCors]
        public IEnumerable<SecondaryWeapon> Get() {
            return _context.SecondaryWeapons;
        }

        [HttpGet("{id:int}")]
        [EnableCors]
        public SecondaryWeapon Get(int id) {
            return _context.SecondaryWeapons.Find(id);
        }
    }
}
