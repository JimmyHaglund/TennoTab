using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class SpyMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public string MissionName { get; set; }
        [Key] public byte UnlockedVaultNumber { get; set; }
        public float DropChance { get; set; }
    }
}
