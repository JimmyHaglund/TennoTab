using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class ExterminateMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public string MissionName { get; set; }
        public float DropChance { get; set; }
    }
}
