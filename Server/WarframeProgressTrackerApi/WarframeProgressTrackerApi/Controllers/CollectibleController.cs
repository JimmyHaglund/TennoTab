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
        public IEnumerable<Collectible> All() {

            return new List<Collectible>() { new Collectible() {
                Id = 1,
                Name = "Debug Collectible",
                Category = "Null Category"
            }
            };

            var searchForm = new CollectibleSearchForm() {
                IncludeFrames = true,
                IncludePrimaryWeapons = true,
                IncludeSecondaryWeapons = true,
                IncludeMeleeWeapons = true,
                IncludePets = true,
                IncludeRoboWeapons = true,
                IncludeOperatorAmps = true,
                IncludeArchwings = true,
                IncludeArchGuns = true,
                IncludeArchMeleeWeapons = true,
                OnlyOnWishlist = false,
                IncludeOwned = true,
                IncludeMastered = true
            };
            var userId = _sessionUser.IdFromRequest(Request);
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

        [HttpPut]
        public Collectible GetWithName([FromBody] CollectibleInfo info) {
            var dataSet = _context.GetDataSet(info.Category);
            var item = dataSet
                .Where(item => item.Name == info.Name)
                .FirstOrDefault();
            if (item == null) return null;
            var userId = _sessionUser.IdFromRequest(Request);
            var userItems = GetCategoryCollection(info.Category);
            var userItem = userItems
                        .Where(userItem => userItem.ItemId == item.Id && userItem.UserId == userId)
                        .FirstOrDefault();
            var collectible = new Collectible() {
                Id = item.Id,
                Name = item.Name,
                Category = info.Category
            };
            if (userItem == null) userItem = Create(collectible, userId);
            collectible.Mastered = userItem.MasteryRank >= 30 ? true : false;
            collectible.Obtained = userItem.Obtained;
            collectible.OnWishlist = userItem.OnWishlist;
            return collectible;
        }
        /**/
        [HttpPut]
        public IEnumerable<Source> GetSource([FromBody] Label label) {
            return _context.Sources.Where(source => source.ItemName == label.Name);
        }
        /**/
        private IEnumerable<Collectible> GrabFrames(CollectibleSearchForm form, string userId) {
            if (form.IncludeFrames) {
                var frames = _context.Frames.ToArray();
                var userItems = _context.UserFrames
                    .Where(item => item.UserId == userId);
                return Grab(frames, userItems, "Warframe", "frame", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPrimaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludePrimaryWeapons) {
                var weapons = _context.PrimaryWeapons.ToArray();
                var userItems = _context.UserFrames
                    .Where(item => item.UserId == userId);
                return Grab(weapons, userItems, "Primary Weapon", "primaryweapon", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabSecondaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeSecondaryWeapons) {
                var weapons = _context.SecondaryWeapons.ToArray();
                var userWeapons = _context.UserSecondaryWeapons
                    .Where(uw => uw.UserId == userId)
                    .Cast<UserCollectible>();
                return Grab(weapons, userWeapons, "Secondary Weapon", "secondaryweapon", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeMeleeWeapons) {
                var weapons = _context.MeleeWeapons.ToArray();
                var userWeapons = _context.UserMeleeWeapons
                    .Where(item => item.UserId == userId);
                return Grab(weapons, userWeapons, "Melee Weapon", "meleeweapon", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabAmps(CollectibleSearchForm form, string userId) {
            if (form.IncludeOperatorAmps) {
                var amps = _context.Amps.ToArray();
                var userAmps = _context.UserAmps
                    .Where(item => item.UserId == userId);
                return Grab(amps, userAmps, "Amp Prism", "amp", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPets(CollectibleSearchForm form, string userId) {
            if (form.IncludePets) {
                var pets = _context.Pets.ToArray();
                var userPets = _context.UserPets
                    .Where(userItem => userItem.UserId == userId);
                return Grab(pets, userPets, "Pet", "pet", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabRoboWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeRoboWeapons) {
                var weapons = _context.RoboWeapons.ToArray();
                var userWeapons = _context.UserRoboWeapons
                    .Where(userItem => userItem.UserId == userId);
                return Grab(weapons, userWeapons, "Robo-Gun", "robogun", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchwings(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchwings) {
                var wings = _context.Archwings.ToArray();
                var userArchwings = _context.UserArchwings
                    .Where(uw => uw.UserId == userId);
                return Grab(wings, userArchwings, "Archwing", "archwing", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchguns(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchGuns) {
                var guns = _context.ArchGuns.ToArray();
                var userGuns = _context.UserArchGuns
                    .Where(uw => uw.UserId == userId);
                return Grab(guns, userGuns, "Archgun", "archgun", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchMeleeWeapons) {
                var weapons = _context.ArchMeleeWeapons.ToArray();
                var userWeapons = _context.UserArchMeleeWeapons
                    .Where(uw => uw.UserId == userId);
                return Grab(weapons, userWeapons, "Arch-Melee", "archmelee", form);
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> Grab(
            IEnumerable<WarframeItem> items,
            IEnumerable<UserCollectible> userItems,
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

        private bool Update(IEnumerable<UserCollectible> items, Collectible collectible, string userId) {
            var userItem = items
                        .Where(userItem => userItem.ItemId == collectible.Id && userItem.UserId == userId)
                        .FirstOrDefault();
            if (userItem == null) return false;
            userItem.Obtained = collectible.Obtained;
            userItem.MasteryRank = (collectible.Obtained && collectible.Mastered) ? 30 : 0;
            userItem.OnWishlist = collectible.OnWishlist;
            _context.SaveChanges();
            return true;
        }

        private UserCollectible Create(Collectible collectible, string userId) {
            UserCollectible newItem = null;
            switch (collectible.Category) {
                case Categories.Warframe:
                    var newFrame = CreateUserItem<UserFrame>(userId, collectible);
                    _context.UserFrames.Add(newFrame);
                    newItem = newFrame;
                    break;
                case Categories.PrimaryWeapon:
                    var newPrimary = CreateUserItem<UserPrimaryWeapon>(userId, collectible);
                    _context.UserPrimaryWeapons.Add(newPrimary);
                    newItem = newPrimary;
                    break;
                case Categories.SecondaryWeapon:
                    var newSecondary = CreateUserItem<UserSecondaryWeapon>(userId, collectible);
                    _context.UserSecondaryWeapons.Add(newSecondary);
                    newItem = newSecondary;
                    break;
                case Categories.MeleeWeapon:
                    var newMelee = CreateUserItem<UserMeleeWeapon>(userId, collectible);
                    _context.UserMeleeWeapons.Add(newMelee);
                    newItem = newMelee;
                    break;
                case Categories.Amp:
                    var newAmp = CreateUserItem<UserAmp>(userId, collectible);
                    _context.UserAmps.Add(newAmp);
                    newItem = newAmp;
                    break;
                case Categories.Pet:
                    var newPet = CreateUserItem<UserPet>(userId, collectible);
                    _context.UserPets.Add(newPet);
                    newItem = newPet;
                    break;
                case Categories.RoboGun:
                    var newRoboGun = CreateUserItem<UserRoboGun>(userId, collectible);
                    _context.UserRoboWeapons.Add(newRoboGun);
                    newItem = newRoboGun;
                    break;
                case Categories.Archwing:
                    var newArchwing = CreateUserItem<UserArchwing>(userId, collectible);
                    _context.UserArchwings.Add(newArchwing);
                    newItem = newArchwing;
                    break;
                case Categories.ArchGun:
                    var newArchGun = CreateUserItem<UserArchGun>(userId, collectible);
                    _context.UserArchGuns.Add(newArchGun);
                    newItem = newArchGun;
                    break;
                case Categories.ArchMelee:
                    var newArchMelee = CreateUserItem<UserArchMelee>(userId, collectible);
                    _context.UserArchMeleeWeapons.Add(newArchMelee);
                    newItem = newArchMelee;
                    break;
            }

            _context.SaveChanges();
            return newItem;
        }

        private T CreateUserItem<T>(string userId, Collectible collectbile) where T : UserCollectible, new() {
            return new T() {
                UserId = userId,
                ItemId = collectbile.Id,
                OnWishlist = collectbile.OnWishlist,
                MasteryRank = collectbile.Mastered ? 30 : 0,
                Obtained = collectbile.Obtained ? true : false
            };
        }

        private IEnumerable<UserCollectible> GetCategoryCollection(string category) {
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
