using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class NorasChoiceNightwaveOffering {
        [Key] public string ItemName { get; set; }
        public string CredsCost { get; set; }
    }
}
