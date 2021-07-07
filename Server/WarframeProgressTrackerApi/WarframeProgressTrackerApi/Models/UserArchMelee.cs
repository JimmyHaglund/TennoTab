using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class UserArchMelee {
        public string UserId { get; set; }
        public int WeaponId { get; set; }
        public int MasteryRank { get; set; } = 0;
        public bool Obtained { get; set; } = false;
    }
}
