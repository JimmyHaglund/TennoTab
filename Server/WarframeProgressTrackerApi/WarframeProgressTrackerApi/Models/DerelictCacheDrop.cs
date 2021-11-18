using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class DerelictCacheDrop {
        [Key] public string ItemName { get; set; }
        [Key] public string System { get; set; }
        [Key] public char Rotation { get; set; }
        [Key] public string Faction { get; set; }
        public float DropChance { get; set; }
    }
}
