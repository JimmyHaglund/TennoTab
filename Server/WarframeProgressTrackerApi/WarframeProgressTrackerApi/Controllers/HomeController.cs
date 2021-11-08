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

        public IEnumerable<Collectible> Index() {
            var form = new CollectibleSearchForm() {
                IncludeFrames = true,
                OnlyOnWishlist = false
            };
            var userId = _sessionUser.IdFromRequest(Request);

            return GrabFrames(form, userId);
        }

        private IEnumerable<Collectible> GrabFrames(CollectibleSearchForm form, string userId) {
            if (form.IncludeFrames) {
                var frames = _context.Frames.ToArray();
                var userItems = _context.UserFrames
                    .Where(item => item.UserId == userId);
                return Grab(frames, userItems, "Warframe", "frame", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> Grab(
                IEnumerable<WarframeItem> items,
                IEnumerable<UserItem> userItems,
                string category, string link,
                CollectibleSearchForm form
                ) {
            return items.
                Where(item => {
                    if (!form.OnlyOnWishlist) return true;
                    var userItem = userItems.FirstOrDefault(uItem => uItem.ItemId == item.Id);
                    if (userItem != null && userItem.OnWishlist) return true;
                    return false;
                })
                .Select(item => {
                    var userItem = userItems.FirstOrDefault(uItem => uItem.ItemId == item.Id);
                    return new Collectible() {
                        Id = item.Id,
                        Name = item.Name,
                        Category = category,
                        DetailsLink = link + "/" + item.Id,
                        Obtained = userItem != null ? userItem.Obtained : false,
                        Mastered = userItem != null ? userItem.MasteryRank >= 30 : false,
                        OnWishlist = userItem != null ? userItem.OnWishlist : false
                    };
                });
        }
    }
}