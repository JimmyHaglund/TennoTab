using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class Collectible {
        [Key] public string ItemName { get; set; }
        public string Category { get; set; }
    }
}
