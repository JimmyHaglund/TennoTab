using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class ExterminateResourceCacheRewards {
        [Key] public string ItemName { get; set; }
        [Key] public string MissionName { get; set; }
        [Key] public byte CacheNumber { get; set; }
        public float DropChance { get; set; }
    }
}
