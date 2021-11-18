using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class KuvaItem {
        [Key] public string ItemName { get; set; }
    }
}
