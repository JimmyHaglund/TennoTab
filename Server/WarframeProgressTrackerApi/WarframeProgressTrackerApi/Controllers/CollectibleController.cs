using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using WarframeProgressTrackerApi.Data;
using WarframeProgressTrackerApi.Models;
using WarframeProgressTrackerApi.Services;
using WarframeProgressTrackerApi.ViewModels;

namespace WarframeProgressTrackerApi.Controllers {
    [Route("[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class CollectibleController : ControllerBase {
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;

        private static class Categories {
            public const string Warframe = "Warframe";
            public const string PrimaryWeapon = "Primary Weapon";
            public const string SecondaryWeapon = "Secondary Weapon";
            public const string MeleeWeapon = "Melee Weapon";
            public const string Amp = "Amp Prism";
            public const string Pet = "Pet";
            public const string RoboGun = "Robo-Gun";
            public const string Archwing = "Archwing";
            public const string ArchGun = "Archgun";
            public const string ArchMelee = "Arch-Melee";
        }

        public CollectibleController(
            WarframeProgressTrackerContext context,
            SessionUser sessionUser) {
            _context = context;
            _sessionUser = sessionUser;
        }

        [HttpGet]
        public IEnumerable<CollectibleView> All() {
            var userId = _sessionUser.IdFromRequest(Request);
            var collectibleViews = GetCollectibleViews(GetInclusiveSearchForm());
            return collectibleViews.ToList();
        }

        [HttpPut]
        public IEnumerable<CollectibleView> Get([FromBody] CollectibleSearchForm searchForm) {
            var userId = _sessionUser.IdFromRequest(Request);
            var collectibles = GetCollectibleViews(searchForm);
            if (userId == "") return collectibles;
            var result = from userCollectible in _context.UserCollectibles
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

        private IEnumerable<CollectibleView> GetCollectibleViews(CollectibleSearchForm searchForm) {
            return from collectible in _context.Collectibles
                   where collectible.ItemName.Contains(searchForm.SearchText)
                   where collectible.Category == Categories.Warframe && searchForm.IncludeFrames
                        || collectible.Category == Categories.PrimaryWeapon && searchForm.IncludePrimaryWeapons
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
    }
}
