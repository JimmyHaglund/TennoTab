using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class Mission {
        [Key] public string MissionName { get; set; }
        public string PlanetName { get; set; }
        public string MissionType { get; set; }
    }
}
