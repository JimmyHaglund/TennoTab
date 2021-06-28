using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Controllers {
    [ApiController]
    [Route("[Controller]")]
    public class FrameController : ControllerBase {
        [HttpGet]
        [EnableCors]
        public IEnumerable<Frame> Get() {
            var frame = new Frame() {
                Id = 0,
                Name = "Excalibur",
                Health = 110,
                Shield = 50,
                Armor = 100,
                Energy = 100,
                SprintSpeed = 1,
                Polarities = "UAF",
                ExilusPolarity = "E",
                AuraPolarity = "A",
                SubsumedAbility = 0
            };
            return new Frame[] { frame };
        }
    }
}
