using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class VoidRelicDrop {
        [Key] public string RelicName { get; set; }
        [Key] public string ItemName { get; set; }
        public float Rarity { get; set; }
    }
}
