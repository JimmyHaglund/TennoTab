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
    public class PrimaryWeaponController : Controller {
        public PrimaryWeaponController(WarframeProgressTrackerContext context) =>
            _context = context;

        private WarframeProgressTrackerContext _context;

        [HttpGet]
        [EnableCors]
        public IEnumerable<PrimaryWeapon> Get() {
            return _context.PrimaryWeapons;
        }

        [HttpGet("{id:int}")]
        [EnableCors]
        public PrimaryWeapon Get(int id) {
            return _context.PrimaryWeapons.Find(id);
        }
    }
}
