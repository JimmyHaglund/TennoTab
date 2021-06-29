using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public static class SecondaryWeaponSeed {
        public static IEnumerable<SecondaryWeapon> Get => 
            new List<SecondaryWeapon>() {
                new SecondaryWeapon() {
                Id = 1,
                Name = "Cestra",
                MasteryRankRequired = 4,
                WeaponType = Pistol,
                AmmoType = Pistol,
                TriggerType = Auto,
                ProjectileType = Projectile,
                FireRate = 8.33f,
                Accuracy = 33.33f,
                MagazineSize = 60,
                MaxAmmo = 420,
                ReloadSeconds = 2.0f,
                Disposition = 1.52f
            },
            new SecondaryWeapon() {
                Id = 2,
                Name = "Lex",
                MasteryRankRequired = 3,
                WeaponType = Pistol,
                AmmoType = Pistol,
                TriggerType = Semi,
                ProjectileType = HitScan,
                FireRate = 1.08f,
                Accuracy = 16.0f,
                MagazineSize = 6,
                MaxAmmo = 210,
                ReloadSeconds = 2.35f,
                Disposition = 1.25f
            },
            new SecondaryWeapon() {
                Id = 3,
                Name = "Pyrana",
                MasteryRankRequired = 12,
                WeaponType = Shotgun,
                AmmoType = Shotgun,
                TriggerType = Auto,
                ProjectileType = HitScan,
                FireRate = 4.17f,
                Accuracy = 5.0f,
                MagazineSize = 10,
                MaxAmmo = 210,
                ReloadSeconds = 2.0f,
                Disposition = 0.95f
            }
        };

        private static string Auto => "Auto";
        private static string Semi => "Semi-Auto";
        private static string Pistol => "Pistol";
        private static string Shotgun => "Shotgun Sidearm";
        private static string Projectile => "Projectile";
        private static string HitScan => "Hit Scan";
    }
}
