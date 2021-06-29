using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.Data {
    public static class MeleeWeaponSeed {
        public static IEnumerable<MeleeWeapon> Get =>
            new MeleeWeapon[] {
                new MeleeWeapon() {
                    Id = 1,
                    Name = "Skana",
                    MasteryRankRequired = 0,
                    WeaponType = Sword,
                    RangeMetres = 2.5f,
                    AttackSpeed = 0.833f,
                    BlockAngleDegrees = 55,
                    ComboSeconds = 5,
                    FollowThrough = 0.6f,
                    Disposition = 1.3f
                },
                new MeleeWeapon() {
                    Id = 2,
                    Name = "Ankyros",
                    MasteryRankRequired = 2,
                    WeaponType = Fist,
                    RangeMetres = 1.25f,
                    AttackSpeed = 1.17f,
                    BlockAngleDegrees = 50,
                    ComboSeconds = 5,
                    FollowThrough = 0.9f,
                    Disposition = 1.45f
                },
                new MeleeWeapon() {
                    Id = 3,
                    Name = "Ceramic Dagger",
                    MasteryRankRequired = 3,
                    WeaponType = Dagger,
                    RangeMetres = 1.8f,
                    AttackSpeed = 1.0f,
                    BlockAngleDegrees = 45,
                    ComboSeconds = 5,
                    FollowThrough = 0.9f,
                    Disposition = 1.43f
                }

            };
        private static string Sword => "Sword";
        private static string Fist => "Fist";
        private static string Dagger => "Dagger";
    }
}
