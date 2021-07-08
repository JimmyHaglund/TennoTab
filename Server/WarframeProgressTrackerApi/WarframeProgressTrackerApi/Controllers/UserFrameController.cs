using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    [ApiController]
    [Route("[Controller]")]
    [Authorize]
    public class UserFrameController : ControllerBase{
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;

        public UserFrameController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<UserItem> Get() {
            var userId = _sessionUser.IdFromRequest(Request);
            if (string.IsNullOrEmpty(userId)) return null;
            return _context.UserFrames.Where(userFrame =>
                userFrame.UserId == userId);
        }

        [HttpPost]
        [EnableCors]
        public UserItem Create(UserFrameCreateModel frameForm) {
            var userId = _sessionUser.IdFromRequest(Request);
            if (string.IsNullOrEmpty(userId)) return null;
            var frame = _context.Frames.FirstOrDefault(dbFrame => dbFrame.Id == frameForm.FrameId);
            if (frame == null) return null;

            var userFrame = new UserFrame() {
                UserId = userId,
                ItemId = frameForm.FrameId,
                Obtained = frameForm.Obtained, 
                MasteryRank = frameForm.MasteryRank 
            };
            _context.UserFrames.Add(userFrame);
            _context.SaveChanges();

            return userFrame;
        }
    }
}