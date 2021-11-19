using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase {
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;

        public HomeController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        public string Index() {
            return "Welcome to Warframe Progress Tracker!";
        }
    }
}