using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class DailyTributeMilestoneReward {
        [Key] public string ItemName { get; set; }
        public uint AvailableFromDay { get; set; }
    }
}
