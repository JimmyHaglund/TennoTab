using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class EnemyTileset {
        [Key] public string EnemyName { get; set; }
        [Key] public string TilesetName { get; set; }
    }
}
