using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public static class PrimaryWeaponSeed {
        public static IEnumerable<PrimaryWeapon> Get => 
            new List<PrimaryWeapon>() {
                new PrimaryWeapon() {
                Id = 1,
                Name = "Bubunico",
                WeaponType = "Arm Cannon",
                AmmoType = "Arm Cannon",
                TriggerType = Auto,
                ProjectileType = Projectile,
                FireRate = 3.83f,
                Accuracy = 25.0f,
                MagazineSize = 27,
                MaxAmmo = 0,
                ReloadSeconds = 16.875f,
                Disposition = 0.7f
            },
            new PrimaryWeapon() {
                Id = 2,
                Name = "Acceltra",
                MasteryRankRequired = 8,
                WeaponType = Rifle,
                AmmoType = Rifle,
                TriggerType = Auto,
                ProjectileType = Projectile,
                FireRate = 12.0f,
                Accuracy = 23.5f,
                MagazineSize = 48,
                MaxAmmo = 96,
                ReloadSeconds = 2.0f,
                Disposition = 0.6f
            },
            new PrimaryWeapon() {
                Id = 3,
                Name = "Corinth",
                MasteryRankRequired = 14,
                WeaponType = Shotgun,
                AmmoType = Shotgun,
                TriggerType = Semi,
                ProjectileType = HitScan,
                FireRate = 1.42f,
                Accuracy = 9.1f,
                MagazineSize = 20,
                MaxAmmo = 120,
                ReloadSeconds = 3.0f,
                Disposition = 0.9f
            }
        };

        private static string Auto => "Auto";
        private static string Semi => "Semi-Auto";
        private static string Rifle => "Rifle";
        private static string Shotgun => "Shotgun";
        private static string Projectile => "Projectile";
        private static string HitScan => "Hit Scan";
    }
}
