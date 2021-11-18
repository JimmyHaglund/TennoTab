using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class DefenseMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public char Rotation { get; set; }
        [Key] public string MissionName { get; set; }
        public float DropChance { get; set; }
    }
}
