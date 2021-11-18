using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class BaroKiteerProduct {
        public string ItemName { get; set; }
        public int CreditsCost { get; set; }
        public int DucatsCost { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
