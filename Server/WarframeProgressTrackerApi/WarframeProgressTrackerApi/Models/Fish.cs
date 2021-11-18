using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class Fish {
        [Key] public string FishName { get; set; }
        [Key] public string Biome { get; set; }
        public string Location { get; set; }
        public string Condition { get; set; }
        public string Bait { get; set; }
    }
}
