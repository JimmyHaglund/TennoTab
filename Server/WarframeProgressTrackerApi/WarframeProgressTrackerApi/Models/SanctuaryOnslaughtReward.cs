using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class SanctuaryOnslaughtReward {
        [Key] public string ItemName { get; set; }
        [Key] public char Rotation { get; set; }
        public float DropChance { get; set; }
    }
}
