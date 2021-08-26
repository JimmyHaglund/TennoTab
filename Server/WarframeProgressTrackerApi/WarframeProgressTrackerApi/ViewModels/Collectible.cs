using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.ViewModels {
    public class Collectible {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string DetailsLink { get; set; }
        public bool Obtained { get; set; }
        public bool Mastered { get; set; }
        public bool OnWishlist { get; set; }
    }
}
