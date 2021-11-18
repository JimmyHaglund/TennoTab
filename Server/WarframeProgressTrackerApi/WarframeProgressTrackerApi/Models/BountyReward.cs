using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class BountyReward {
        [Key] public string ItemName { get; set; }
        [Key] public string Location { get; set; }
        [Key] public char Rotation { get; set; }
        [Key] public byte BountyTier { get; set; }
        [Key] public byte BountyStage { get; set; }
        public float DropChance { get; set; }
    }
}
