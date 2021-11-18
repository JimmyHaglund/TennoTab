using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class AssassinationMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public string Mission { get; set; }
        public float DropChance { get; set; }
    }
}
