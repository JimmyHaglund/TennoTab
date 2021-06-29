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
    public class FrameController : ControllerBase {
        public FrameController(WarframeProgressTrackerContext context) =>
            _context = context;

        private WarframeProgressTrackerContext _context;

        [HttpGet]
        [EnableCors]
        public IEnumerable<Frame> Get() {
            return _context.Frames;

        }

        [HttpGet("{id:int}")]
        [EnableCors]
        public Frame Get(int id) {
            return _context.Frames.Find(id);
        } 
    }
}
