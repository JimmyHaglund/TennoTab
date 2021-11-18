using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class BlueprintComponent {
        [Key] public string ResultName { get; set; }
        [Key] public string ComponentName { get; set; }
        public int ComponentCount { get; set; }
    }
}
