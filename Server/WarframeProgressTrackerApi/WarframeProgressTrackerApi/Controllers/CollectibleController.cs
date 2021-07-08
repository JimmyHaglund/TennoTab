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
                return Grab(frames, userFrames, "Warframe", "frame");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPrimaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludePrimaryWeapons) {
                var weapons = _context.PrimaryWeapons.ToArray();
                var userWeapons = _context.UserPrimaryWeapons.Where(uw=> uw.UserId == userId);
                return Grab(weapons, userWeapons, "Primary Weapon", "primaryweapon");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabSecondaryWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeSecondaryWeapons) {
                var weapons = _context.SecondaryWeapons.ToArray();
                var userWeapons = _context.UserSecondaryWeapons.Where(uw => uw.UserId == userId);
                return Grab(weapons, userWeapons, "Secondary Weapon", "secondaryweapon");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabMeleeWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeMeleeWeapons) {
                var weapons = _context.MeleeWeapons.ToArray();
                var userWeapons = _context.UserMeleeWeapons.Where(item => item.UserId == userId);
                return Grab(weapons, userWeapons, "Melee Weapon", "meleeweapon");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabAmps(CollectibleSearchForm form, string userId) {
            if (form.IncludeOperatorAmps) {
                var amps = _context.Amps.ToArray();
                var userAmps = _context.UserAmps.Where(item => item.UserId == userId);
                return Grab(amps, userAmps, "Amp Prism", "amp");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabPets(CollectibleSearchForm form, string userId) {
            if (form.IncludePets) {
                var pets = _context.Pets.ToArray();
                var userPets = _context.UserPets.Where(userItem => userItem.UserId == userId);
                return Grab(pets, userPets, "Pet", "pet");
            }
            return new Collectible[0];
        }

        private IEnumerable<Collectible> GrabRoboWeapons(CollectibleSearchForm form, string userId) {
            if (form.IncludeRoboWeapons) {
                var weapons = _context.RoboWeapons.ToArray();
                var userWeapons = _context.UserRoboWeapons.Where(userItem => userItem.UserId == userId);
                return Grab(weapons, userWeapons, "Robo-Gun", "robogun");
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
                return Grab(weapons, userWeapons, "Arch-Melee", "archmelee");
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
