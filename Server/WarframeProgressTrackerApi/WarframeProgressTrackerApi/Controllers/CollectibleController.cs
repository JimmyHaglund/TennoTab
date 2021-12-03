using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    // [Route("[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class CollectibleController : ControllerBase {
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;

        private static class Categories {
            public const string Warframe = "Warframe";
            public const string PrimaryWeapon = "PrimaryWeapon";
            public const string SecondaryWeapon = "SecondaryWeapon";
            public const string MeleeWeapon = "MeleeWeapon";
            public const string Amp = "AmpPrism";
            public const string Pet = "Companion";
            public const string RoboGun = "RoboticWeapon";
            public const string Archwing = "ArchWing";
            public const string ArchGun = "ArchGun";
            public const string ArchMelee = "ArchMelee";
        }

        public CollectibleController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        [HttpGet]

        [Route("[controller]/[action]")]
        public IEnumerable<CollectibleView> All() {
            var collectibleViews = GetCollectibleViews(GetInclusiveSearchForm());
            var userId = _sessionUser.IdFromRequest(Request);
            if (string.IsNullOrEmpty(userId)) {
                return collectibleViews.ToList();
            }

            var userCollectibles = from userCollectible in _context.UserCollectibles
                                   where userCollectible.UserId == userId
                                   select userCollectible;

            return from userCollectible in userCollectibles
                   from collectible in collectibleViews
                   where userCollectible.ItemName == collectible.Name
                   select new CollectibleView() {
                       Name = collectible.Name,
                       Category = collectible.Category,
                       OnWishlist = userCollectible.OnWishlist,
                       Obtained = userCollectible.Obtained,
                       Mastered = userCollectible.Mastered
                   };
        }

        [HttpGet]
        [Route("[controller]/[action]/{itemName}")]
        public CollectibleView Get(string itemName) {
            var userId = _sessionUser.IdFromRequest(Request);
            var result = from userCollectible in _context.UserCollectibles
                         where userCollectible.ItemName == itemName
                         from collectible in _context.Collectibles
                         where collectible.ItemName == itemName
                         select new CollectibleView() {
                             Name = itemName,
                             Category = collectible.Category,
                             Obtained = userCollectible.Obtained,
                             Mastered = userCollectible.Mastered,
                             OnWishlist = userCollectible.OnWishlist
                         };
            return result.FirstOrDefault();
        }

        [HttpPut]
        [Route("[controller]/[action]")]
        public IEnumerable<CollectibleView> Get([FromBody] CollectibleSearchForm searchForm) {
            var userId = _sessionUser.IdFromRequest(Request);
            var collectibles = GetCollectibleViews(searchForm);
            if (userId == "") return searchForm.OnlyOnWishlist ? new CollectibleView[0] : collectibles;
            var userCollectibles = from userCollectible in _context.UserCollectibles
                                   where userCollectible.UserId == userId
                                   where !searchForm.OnlyOnWishlist || userCollectible.OnWishlist
                                   where searchForm.IncludeMastered || !userCollectible.Mastered
                                   where searchForm.IncludeOwned || !userCollectible.Obtained
                                   select userCollectible;

            var result = from userCollectible in userCollectibles
                         from collectible in collectibles
                         where userCollectible.ItemName == collectible.Name
                         select new CollectibleView() {
                             Name = collectible.Name,
                             Category = collectible.Category,
                             Obtained = userCollectible.Obtained,
                             Mastered = userCollectible.Mastered,
                             OnWishlist = userCollectible.OnWishlist
                         };
            return result.ToList();
        }

        [HttpPut]
        [Route("[controller]/[action]")]
        public void Put([FromBody] CollectibleView collectible) {
            var userId = _sessionUser.IdFromRequest(Request);
            var targets = from userCollectible in _context.UserCollectibles
                          where userCollectible.UserId == userId
                          where userCollectible.ItemName == collectible.Name
                          select userCollectible;
            var target = targets.FirstOrDefault();
            if (target == default) return;
            target.Obtained = collectible.Obtained;
            target.Mastered = collectible.Mastered;
            target.OnWishlist = collectible.OnWishlist;
            _context.SaveChanges();
        }

        [HttpPut]
        [Route("[controller]/[action]/{name}")]
        [Authorize(Roles = "Administrator")]
        public ActionResult Update(string name, [FromBody] CollectibleView inCollectible) {
            if (string.IsNullOrEmpty(name) || !CollectibleExists(name)) {
                return BadRequest("Collectible with name '" + name + "' not found");
            }
            if (name != inCollectible.Name && CollectibleExists(inCollectible.Name)) {
                return BadRequest("Cannot change collectible name to " + inCollectible.Name +
                    ": A collectible already exists with that name.");
            }
            if (string.IsNullOrEmpty(inCollectible.Category)) {
                return BadRequest("Collectible category must be defined.");
            }
            var collectible = new Collectible() {
                ItemName = inCollectible.Name,
                Category = inCollectible.Category
            };
            _context.UpdateCollectibleData(name, collectible);

            return Ok();
        }

        [HttpPost]
        [Route("[controller]/[action]")]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create([FromBody] CollectibleView inCollectible) {
            if (string.IsNullOrEmpty(inCollectible.Name)) {
                return BadRequest("Collectible must have a name.");
            }
            if (CollectibleExists(inCollectible.Name)) {
                return BadRequest("Collectible with name " + inCollectible.Name + " already exists.");
            }
            if (string.IsNullOrEmpty(inCollectible.Category)) {
                return BadRequest("Collectible category must be defined.");
            }
            var collectible = new Collectible() {
                ItemName = inCollectible.Name,
                Category = inCollectible.Category
            };
            
            _context.CreateCollectibleData(collectible);
           
            return Ok();
        }

        [HttpDelete]
        [Route("[controller]/[action]/{itemName}")]
        [Authorize(Roles = "Administrator")]
        public ActionResult Delete(string itemName) {
            if (!CollectibleExists(itemName)) {
                return BadRequest("Collectible with name " + itemName + " could not be found.");
            }
            _context.RemoveCollectibleData(itemName);
            return Ok();
        }

        private bool CollectibleExists(string name) {
            var existingCollectible = (from collectible in _context.Collectibles
                                       where collectible.ItemName == name
                                       select collectible).FirstOrDefault();
            return existingCollectible != default;
        }

        #region Body
        private IEnumerable<CollectibleView> GetCollectibleViews(CollectibleSearchForm searchForm) {
            return from collectible in _context.Collectibles
                   where collectible.ItemName.Contains(searchForm.SearchText)
                   where (collectible.Category == Categories.Warframe && searchForm.IncludeFrames)
                        || (collectible.Category == Categories.PrimaryWeapon && searchForm.IncludePrimaryWeapons)
                        || collectible.Category == Categories.SecondaryWeapon && searchForm.IncludeSecondaryWeapons
                        || collectible.Category == Categories.MeleeWeapon && searchForm.IncludeMeleeWeapons
                        || collectible.Category == Categories.Pet && searchForm.IncludePets
                        || collectible.Category == Categories.RoboGun && searchForm.IncludeRoboWeapons
                        || collectible.Category == Categories.Amp && searchForm.IncludeOperatorAmps
                        || collectible.Category == Categories.Archwing && searchForm.IncludeArchwings
                        || collectible.Category == Categories.ArchGun && searchForm.IncludeArchGuns
                        || collectible.Category == Categories.ArchMelee && searchForm.IncludeArchMeleeWeapons
                   select new CollectibleView() {
                       Name = collectible.ItemName,
                       Category = collectible.Category
                   };
        }

        private CollectibleSearchForm GetInclusiveSearchForm() {
            return new CollectibleSearchForm() {
                IncludeFrames = true,
                IncludePrimaryWeapons = true,
                IncludeSecondaryWeapons = true,
                IncludeMeleeWeapons = true,
                IncludePets = true,
                IncludeRoboWeapons = true,
                IncludeOperatorAmps = true,
                IncludeArchwings = true,
                IncludeArchGuns = true,
                IncludeArchMeleeWeapons = true
            };
        }
        #endregion
    }
}
