using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class NightwaveOfferingNorasChoice {
        [Key] public string ItemName { get; set; }
        public string CredsCost { get; set; }
    }
}
