﻿using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class MarketItem {
        [Key] public string ItemName { get; set; }
        public int CreditsCost { get; set; }
    }
}
