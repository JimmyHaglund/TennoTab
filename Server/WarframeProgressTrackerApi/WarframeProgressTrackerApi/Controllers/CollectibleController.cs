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
    [Route("[controller]")]
    [ApiController]
    [EnableCors]
    public class CollectibleController : ControllerBase {
        private SessionUser _sessionUser;
        private WarframeProgressTrackerContext _context;
        private const string FRAME = "Warframe";
        private const string PRIMARY = "Primary Weapon";
        private const string SECONDARY = "Secondary Weapon";
        private const string MELEE = "Melee Weapon";
        private const string PET = "Pet";
        private const string ROBOGUN = "Robo-Gun";
        private const string ARCHWING = "Archwing";
        private const string ARCHGUN = "Arch-Gun";
        private const string ARCHMELEE = "Arch-Melee";
        private const string AMP = "Operator Amp";

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
                .Concat(GrabPets(searchForm, userId))
                .Concat(GrabRoboWeapons(searchForm, userId))
                .Concat(GrabArchwings(searchForm, userId))
                .Concat(GrabArchguns(searchForm, userId))
                .Concat(GrabArchMeleeWeapons(searchForm, userId));
        }

        private IEnumerable<Collectible> GrabFrames(CollectibleSearchForm form, string userId) {
            if (form.IncludeFrames) {
                var frames = _context.Frames.ToArray();
                var userFrames = _context.UserFrames.Where(userFrame => userFrame.UserId == userId);
                return frames.Select(frame => {
                    var userFrame = userFrames.FirstOrDefault(uf => uf.ItemId == frame.Id);
                    return new Collectible() {
                        Name = frame.Name,
                        Category = FRAME,
                        DetailsLink = "frame/" + frame.Id,
                        Obtained = userFrame != null ? userFrame.Obtained : false,
                        Mastered = userFrame != null ? userFrame.MasteryRank >= 30 : false
                    };
                });
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPrimaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludePrimaryWeapons) {
                var weapons = _context.PrimaryWeapons.ToArray();
                var userWeapons = _context.UserPrimaryWeapons.Where(uw=> uw.UserId == userId);
                return weapons.Select(weapon => {
                    var userWeapon = userWeapons.FirstOrDefault(uw => uw.ItemId == weapon.Id);
                    return new Collectible() {
                        Name = weapon.Name,
                        Category = PRIMARY,
                        DetailsLink = "primaryweapon/" + weapon.Id,
                        Obtained = userWeapon != null ? userWeapon.Obtained : false,
                        Mastered = userWeapon != null ? userWeapon.MasteryRank >= 30 : false
                    };
                });
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabSecondaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeSecondaryWeapons) {
                var weapons = _context.SecondaryWeapons.ToArray();
                var userWeapons = _context.UserSecondaryWeapons.Where(uw => uw.UserId == userId);
                return weapons.Select(weapon => {
                    var userWeapon = userWeapons.FirstOrDefault(uw => uw.ItemId == weapon.Id);
                    return new Collectible() {
                        Name = weapon.Name,
                        Category = SECONDARY,
                        DetailsLink = "secondaryweapon/" + weapon.Id,
                        Obtained = userWeapon != null ? userWeapon.Obtained : false,
                        Mastered = userWeapon != null ? userWeapon.MasteryRank >= 30 : false
                    };
                });
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeMeleeWeapons) {
                var weapons = _context.MeleeWeapons.ToArray();
                var userWeapons = _context.UserMeleeWeapons.Where(uw => uw.UserId == userId);
                return weapons.Select(weapon => {
                    var userWeapon = userWeapons.FirstOrDefault(uw => uw.ItemId == weapon.Id);
                    return new Collectible() {
                        Name = weapon.Name,
                        Category = MELEE,
                        DetailsLink = "meleeweapon/" + weapon.Id,
                        Obtained = userWeapon != null ? userWeapon.Obtained : false,
                        Mastered = userWeapon != null ? userWeapon.MasteryRank >= 30 : false
                    };
                });
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPets(CollectibleSearchForm form, string userId) {
            if (form.IncludePets) {
                var pets = _context.Pets.ToArray();
                var userPets = _context.UserPets.Where(up => up.UserId == userId);
                return pets.Select(pet => {
                    var userPet = userPets.FirstOrDefault(uw => uw.ItemId == pet.Id);
                    return new Collectible() {
                        Name = pet.Name,
                        Category = PET,
                        DetailsLink = "pet/" + pet.Id,
                        Obtained = userPet != null ? userPet.Obtained : false,
                        Mastered = userPet != null ? userPet.MasteryRank >= 30 : false
                    };
                });
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabRoboWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludePrimaryWeapons) {
                var weapons = _context.RoboWeapons.ToArray();
                var userWeapons = _context.UserRoboWeapons.Where(uw => uw.UserId == userId);
                return weapons.Select(weapon => {
                    var userWeapon = userWeapons.FirstOrDefault(uw => uw.ItemId == weapon.Id);
                    return new Collectible() {
                        Name = weapon.Name,
                        Category = ROBOGUN,
                        DetailsLink = "roboweapon/" + weapon.Id,
                        Obtained = userWeapon != null ? userWeapon.Obtained : false,
                        Mastered = userWeapon != null ? userWeapon.MasteryRank >= 30 : false
                    };
                });
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchwings(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchwings) {
                var wings = _context.Archwings.ToArray();
                var userArchwings = _context.UserArchwings.Where(uw => uw.UserId == userId);
                return Grab(wings, userArchwings, "Archwing", "archwing");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchguns(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchGuns) {
                var guns = _context.ArchGuns.ToArray();
                var userGuns = _context.UserArchGuns.Where(uw => uw.UserId == userId);
                return Grab(guns, userGuns, "Archgun", "archgun");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabArchMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeArchMeleeWeapons) {
                var weapons = _context.ArchMeleeWeapons.ToArray();
                var userWeapons = _context.UserArchMeleeWeapons.Where(uw => uw.UserId == userId);
                return Grab(weapons, userWeapons, ARCHMELEE, "archmelee");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> Grab<T>(
            IEnumerable<T> items, 
            IEnumerable<UserItem> userItems, 
            string category, string link) 
            where T : WarframeItem {
            return items.Select(item => {
                var userItem = userItems.FirstOrDefault(ui => ui.ItemId == item.Id);
                return new Collectible() {
                    Name = item.Name,
                    Category = category,
                    DetailsLink = link + "/" + item.Id,
                    Obtained = userItem != null ? userItem.Obtained : false,
                    Mastered = userItem != null ? userItem.MasteryRank >= 30 : false
                };
            });
        }

    }
}
