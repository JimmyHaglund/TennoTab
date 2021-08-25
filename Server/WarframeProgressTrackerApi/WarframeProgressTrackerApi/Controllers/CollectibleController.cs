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

        [HttpPut]
        public IEnumerable<Collectible> Get([FromBody] CollectibleSearchForm searchForm) {
            var userId = _sessionUser.IdFromRequest(Request);
            if (searchForm == null) searchForm = new CollectibleSearchForm();
            return GrabFrames(searchForm, userId)
                .Concat(GrabPrimaryWeapons(searchForm, userId))
                .Concat(GrabSecondaryWeapons(searchForm, userId))
                .Concat(GrabMeleeWeapons(searchForm, userId))
                .Concat(GrabAmps(searchForm, userId))
                .Concat(GrabPets(searchForm, userId))
                .Concat(GrabRoboWeapons(searchForm, userId))
                .Concat(GrabArchwings(searchForm, userId))
                .Concat(GrabArchguns(searchForm, userId))
                .Concat(GrabArchMeleeWeapons(searchForm, userId));
        }

        [HttpPut]
        public void Set([FromBody] Collectible collectible) {
            var userId = _sessionUser.IdFromRequest(Request);
            var userItems = GetCategoryCollection(collectible.Category);
            if (Update(userItems, collectible, userId)) return;
            Create(collectible, userId);
        }


        private IEnumerable<Collectible> GrabFrames(CollectibleSearchForm form, string userId) {
            if (form.IncludeFrames) {
                var frames = _context.Frames.ToArray();
                var userItems = _context.UserFrames
                    .Where(item => item.UserId == userId);
                return Grab(frames, userItems, "Warframe", "frame");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPrimaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludePrimaryWeapons) {
                var weapons = _context.PrimaryWeapons.ToArray();
                var userItems = _context.UserFrames
                    .Where(item => item.UserId == userId);
                return Grab(weapons, userItems, "Primary Weapon", "primaryweapon");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabSecondaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeSecondaryWeapons) {
                var weapons = _context.SecondaryWeapons.ToArray();
                var userWeapons = _context.UserSecondaryWeapons
                    .Where(uw => uw.UserId == userId)
                    .Cast<UserItem>();
                return Grab(weapons, userWeapons, "Secondary Weapon", "secondaryweapon");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeMeleeWeapons) {
                var weapons = _context.MeleeWeapons.ToArray();
                var userWeapons = _context.UserMeleeWeapons
                    .Where(item => item.UserId == userId);
                return Grab(weapons, userWeapons, "Melee Weapon", "meleeweapon");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabAmps(CollectibleSearchForm form, string userId) {
            if (form.IncludeOperatorAmps) {
                var amps = _context.Amps.ToArray();
                var userAmps = _context.UserAmps
                    .Where(item => item.UserId == userId);
                return Grab(amps, userAmps, "Amp Prism", "amp");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPets(CollectibleSearchForm form, string userId) {
            if (form.IncludePets) {
                var pets = _context.Pets.ToArray();
                var userPets = _context.UserPets
                    .Where(userItem => userItem.UserId == userId);
                return Grab(pets, userPets, "Pet", "pet");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabRoboWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeRoboWeapons) {
                var weapons = _context.RoboWeapons.ToArray();
                var userWeapons = _context.UserRoboWeapons
                    .Where(userItem => userItem.UserId == userId);
                return Grab(weapons, userWeapons, "Robo-Gun", "robogun");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchwings(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchwings) {
                var wings = _context.Archwings.ToArray();
                var userArchwings = _context.UserArchwings
                    .Where(uw => uw.UserId == userId);
                return Grab(wings, userArchwings, "Archwing", "archwing");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchguns(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchGuns) {
                var guns = _context.ArchGuns.ToArray();
                var userGuns = _context.UserArchGuns
                    .Where(uw => uw.UserId == userId);
                return Grab(guns, userGuns, "Archgun", "archgun");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchMeleeWeapons) {
                var weapons = _context.ArchMeleeWeapons.ToArray();
                var userWeapons = _context.UserArchMeleeWeapons
                    .Where(uw => uw.UserId == userId);
                return Grab(weapons, userWeapons, "Arch-Melee", "archmelee");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> Grab(
            IEnumerable<WarframeItem> items,
            IEnumerable<UserItem> userItems,
            string category, string link) {
            return items.Select(item => {
                var userItem = userItems.FirstOrDefault(ui => ui.ItemId == item.Id);
                return new Collectible() {
                    Id = item.Id,
                    Name = item.Name,
                    Category = category,
                    DetailsLink = link + "/" + item.Id,
                    Obtained = userItem != null ? userItem.Obtained : false,
                    Mastered = userItem != null ? userItem.MasteryRank >= 30 : false
                };
            });
        }

        private bool Update(IEnumerable<UserItem> items, Collectible collectible, string userId) {
            var userItem = items
                        .Where(userItem=> userItem.ItemId == collectible.Id && userItem.UserId == userId)
                        .FirstOrDefault();
            if (userItem == null) return false;
            userItem.Obtained = collectible.Obtained;
            userItem.MasteryRank = (collectible.Obtained && collectible.Mastered) ? 30 : 0;
            _context.SaveChanges();
            return true;
        }

        private void Create(Collectible collectible, string userId) {
            switch (collectible.Category) {
                case Categories.Warframe:
                    var newFrame = new UserFrame() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserFrames.Add(newFrame);
                    break;
                case Categories.PrimaryWeapon:
                    var newPrimary = new UserPrimaryWeapon() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserPrimaryWeapons.Add(newPrimary);
                    break;
                case Categories.SecondaryWeapon:
                    var newSecondary = new UserSecondaryWeapon() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserSecondaryWeapons.Add(newSecondary);
                    break;
                case Categories.MeleeWeapon:
                    var newMelee = new UserMeleeWeapon() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserMeleeWeapons.Add(newMelee);
                    break;
                case Categories.Amp:
                    var newAmp = new UserAmp() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserAmps.Add(newAmp);
                    break;
                case Categories.Pet:
                    var newPet = new UserPet() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserPets.Add(newPet);
                    break;
                case Categories.RoboGun:
                    var newRoboGun = new UserRoboGun() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserRoboWeapons.Add(newRoboGun);
                    break;
                case Categories.Archwing:
                    var newArchwing = new UserArchwing() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserArchwings.Add(newArchwing);
                    break;
                case Categories.ArchGun:
                    var newArchGun = new UserArchGun() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserArchGuns.Add(newArchGun);
                    break;
                case Categories.ArchMelee:
                    var newArchMelee = new UserArchMelee() { UserId = userId, ItemId = collectible.Id, MasteryRank = collectible.Mastered ? 30 : 0, Obtained = collectible.Obtained };
                    _context.UserArchMeleeWeapons.Add(newArchMelee);
                    break;
            }

            _context.SaveChanges();
        }

        private IEnumerable<UserItem> GetCategoryCollection(string category) {
            switch (category) {
                case Categories.Warframe: return _context.UserFrames;
                case Categories.PrimaryWeapon: return _context.UserPrimaryWeapons;
                case Categories.SecondaryWeapon: return _context.UserSecondaryWeapons;
                case Categories.MeleeWeapon: return _context.UserMeleeWeapons;
                case Categories.Amp: return _context.UserAmps;
                case Categories.Pet: return _context.UserPets;
                case Categories.RoboGun: return _context.UserRoboWeapons;
                case Categories.Archwing: return _context.UserArchwings;
                case Categories.ArchGun: return _context.UserArchGuns;
                case Categories.ArchMelee: return _context.UserArchMeleeWeapons;
                default: return null;
            }
        }
    }
}
