using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class PrimaryWeapon {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MasteryRankRequired { get; set; } = 0;
        public string WeaponType { get; set; }
        public string AmmoType { get; set; }
        public string TriggerType { get; set; }
        public string ProjectileType { get; set; }
        public float FireRate { get; set; }
        public float Accuracy { get; set; }
        public int MagazineSize { get; set; }
        public int MaxAmmo { get; set; }
        public float ReloadSeconds { get; set; }
        public float Disposition { get; set; }
    }
}
