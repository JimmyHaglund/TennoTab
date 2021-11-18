using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class EnemyItemDrop {
        [Key] public string ItemName { get; set; }
        [Key] public string EnemyName { get; set; }
        public float DropChance { get; set; }
    }
}
