using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class InvasionReward {
        [Key] public string ItemName { get; set; }
    }
}
