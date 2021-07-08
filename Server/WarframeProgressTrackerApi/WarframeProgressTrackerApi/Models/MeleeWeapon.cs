using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class MeleeWeapon : WarframeItem {
        public int MasteryRankRequired { get; set; }
        public string WeaponType { get; set; }
        public float RangeMetres { get; set; }
        public float AttackSpeed { get; set; }
        public int BlockAngleDegrees { get; set; }
        public float ComboSeconds { get; set; }
        public float FollowThrough { get; set; }
        public float Disposition { get; set; }
        public string HowToGet { get; set; } = "";
    }
}
