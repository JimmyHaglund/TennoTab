using System;
using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class BaroKiteerProduct {
        [Key] public string ItemName { get; set; }
        [Key] public DateTime SaleDate { get; set; }
        public int CreditsCost { get; set; }
        public int DucatsCost { get; set; }
    }
}
