using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    [ApiController]
    [Route("[Controller]")]
    public class FrameController : ControllerBase {
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;

        public FrameController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        [HttpGet]
        [EnableCors]
        public IEnumerable<UserFrameData> Get() {
            var frames = _context.Frames.Select(frame => new UserFrameData(frame)).ToArray();
            var userId = GetRequestId(Request);
            if (!string.IsNullOrEmpty(userId)) {
                PopulateWithUserData(frames, userId);
            }
            return frames;
        }

        private void PopulateWithUserData(IEnumerable<UserFrameData> frames, string userId) {
            var userFrames = _context.UserFrames
                    .Where(userFrame => userFrame.UserId == userId);
            foreach (var frame in frames) {
                var userFrame = userFrames
                    .FirstOrDefault(userFrame => userFrame.FrameId == frame.Id);
                if (userFrame != null) {
                    frame.Obtained = userFrame.Obtained;
                    frame.MasteryRank = userFrame.MasteryRank;
                }
            }
        }

        private string GetRequestId(HttpRequest request) {
            var requestCookies = request.Cookies;
            if (request.Cookies.TryGetValue("auth_cookie", out var cookie)) {
                return _sessionUser.Get(cookie);
            }
            return "";
        }

        [HttpGet("{id:int}")]
        [EnableCors]
        public Frame Get(int id) {
            return _context.Frames.Find(id);
        }
    }
}
