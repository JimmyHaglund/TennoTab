using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    [Route("[controller]")]
    [ApiController]
    [EnableCors]
    public class CollectibleController : ControllerBase {
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;

        public CollectibleController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        [HttpGet]
        public IEnumerable<Collectible> Get([FromBody] CollectibleSearchForm searchForm) {
            var userId = _sessionUser.IdFromRequest(Request);
            if (searchForm == null) searchForm = new CollectibleSearchForm();
            var result = GrabFrames(searchForm, userId);

            return result;
        }

        private IEnumerable<Collectible> GrabFrames(CollectibleSearchForm form, string userId) {
            if (form.IncludeFrames) {
                var frames = _context.Frames.ToArray();
                var userFrames = _context.UserFrames.Where(userFrame => userFrame.UserId == userId);
                return frames.Select(frame => {
                    var userFrame = userFrames.FirstOrDefault(uf => uf.FrameId == frame.Id);
                    return new Collectible() {
                        Obtained = userFrame != null ? userFrame.Obtained : false,
                        Mastered = userFrame != null ? userFrame.MasteryRank >= 30 : false,
                        DetailsLink = "frame/" + frame.Id
                    };
                });
            }
            return new Collectible[0];
        }
    }
}
