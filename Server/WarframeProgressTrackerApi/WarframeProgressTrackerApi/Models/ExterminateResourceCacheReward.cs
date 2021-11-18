using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class ExterminateResourceCacheReward {
        [Key] public string ItemName { get; set; }
        [Key] public string MissionName { get; set; }
        [Key] public byte CacheNumber { get; set; }
        public float DropChance { get; set; }
    }
}
