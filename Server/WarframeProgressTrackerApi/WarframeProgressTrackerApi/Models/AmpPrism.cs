using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class AmpPrism : WarframeItem {
        public string TriggerType { get; set; }
        public string ProjectileType { get; set; }
        public float FireRate { get; set; }
        public float Accuracy { get; set; }
        public int MagazineSize { get; set; }
        public float ReloadSeconds { get; set; }
    }
}
