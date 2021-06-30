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
