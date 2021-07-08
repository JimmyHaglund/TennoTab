using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WarframeProgressTrackerApi.Models {
    public class Pet : WarframeItem {
        public string Category { get; set; }
        public int MasteryRankRequired { get; set; } = 0;
        public string HowToGet { get; set; } = "";


        public int Health { get; set; }
        public float HealthMaxFactor { get; set; } = 3.0f;
        public int Shield { get; set; }
        public float ShieldMaxFactor { get; set; } = 3.0f;
        public int Armor { get; set; }
        public float ArmorMaxFactor { get; set; } = 1.0f;
        public string Polarities { get; set; }
    }
}