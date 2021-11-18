using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class SabotageMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public string MissionName { get; set; }
        [Key] public char Rotation { get; set; }
        public float DropChance { get; set; }
    }
}
