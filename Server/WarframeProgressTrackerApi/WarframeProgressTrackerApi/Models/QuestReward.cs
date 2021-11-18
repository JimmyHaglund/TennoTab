using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class QuestReward {
        [Key] public string ItemName { get; set; }
        public string Quest { get; set; }
    }
}
