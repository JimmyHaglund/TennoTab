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
    public class CollectibleInfo {
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public class Label {
        public string Name { get; set; }
    }

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
            var collectibles = GetCollectibles(GetInclusiveSearchForm());
            return from collectible in collectibles
                   select new CollectibleView() {
                       Name = collectible.ItemName,
                       Category = collectible.Category
                   };
        }

        [HttpPut]
        public IEnumerable<CollectibleView> Get([FromBody] CollectibleSearchForm searchForm) {
            var userId = _sessionUser.IdFromRequest(Request);
            if (searchForm == null) searchForm = new CollectibleSearchForm();
            var userCollectibles = GetUserCollectibles(searchForm, userId);
            var collectibles = GetCollectibles(searchForm);

            return null;
        }

        private IEnumerable<UserCollectible> GetUserCollectibles(CollectibleSearchForm searchForm, string userId) {
            return null;
        }

        private IEnumerable<Collectible> GetCollectibles(CollectibleSearchForm searchForm) {
            return from collectible in _context.Collectibles
                   where collectible.ItemName.Contains(searchForm.SearchText)
                   where AllowedCategory(collectible, searchForm)
                   select collectible;
        }

        private bool AllowedCategory(Collectible collectible, CollectibleSearchForm searchForm) {
            return collectible.Category == Categories.Warframe && searchForm.IncludeFrames
                || collectible.Category == Categories.PrimaryWeapon && searchForm.IncludePrimaryWeapons
                || collectible.Category == Categories.SecondaryWeapon && searchForm.IncludeSecondaryWeapons
                || collectible.Category == Categories.MeleeWeapon && searchForm.IncludeMeleeWeapons
                || collectible.Category == Categories.Pet && searchForm.IncludePets
                || collectible.Category == Categories.RoboGun && searchForm.IncludeRoboWeapons
                || collectible.Category == Categories.Amp && searchForm.IncludeOperatorAmps
                || collectible.Category == Categories.Archwing && searchForm.IncludeArchwings
                || collectible.Category == Categories.ArchGun && searchForm.IncludeArchGuns
                || collectible.Category == Categories.ArchMelee && searchForm.IncludeArchMeleeWeapons;
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
