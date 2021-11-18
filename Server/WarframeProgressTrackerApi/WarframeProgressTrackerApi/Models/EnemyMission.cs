using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class EnemyMission {
        [Key] public string EnemyName { get; set; }
        [Key] public string MissionName { get; set; }
    }
}
