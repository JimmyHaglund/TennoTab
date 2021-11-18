using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class VoidFissureMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public string SystemName { get; set; }
        public float DropChance { get; set; }
    }
}
