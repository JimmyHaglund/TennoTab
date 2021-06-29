using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Data;

namespace WarframeProgressTrackerApi.Controllers {
    [ApiController]
    [Route("[Controller]")]
    public class MeleeWeaponController : ControllerBase {
        public MeleeWeaponController(WarframeProgressTrackerContext context) =>
            _context = context;

        private WarframeProgressTrackerContext _context;

        [HttpGet]
        [EnableCors]
        public IEnumerable<MeleeWeapon> Get() {
            return _context.MeleeWeapons;
        }

        [HttpGet("{id:int}")]
        [EnableCors]
        public MeleeWeapon Get(int id) {
            return _context.MeleeWeapons.Find(id);
        }
    }
}
