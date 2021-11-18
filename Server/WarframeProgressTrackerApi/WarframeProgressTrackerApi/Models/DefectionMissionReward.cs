using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class DefectionMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public char Rotation { get; set; }
        public string Mission { get; set; }
        public float DropChance { get; set; }

    }
}
