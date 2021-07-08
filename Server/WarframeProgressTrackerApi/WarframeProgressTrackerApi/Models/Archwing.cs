using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class Archwing : WarframeItem {
        public string HowToGet { get; set; } = "";
        public int MasteryRankRequired { get; set; } = 0;

        public int Health { get; set; }
        public float HealthMaxFactor { get; set; } = 3.0f;
        public int Shield { get; set; }
        public float ShieldMaxFactor { get; set; } = 3.0f;
        public int Armor { get; set; }
        public float ArmorMaxFactor { get; set; } = 1.0f;
        public int Energy { get; set; }
        public float EnergyMaxFactor { get; set; } = 1.8f;

        public float FlightSpeed { get; set; }
        public string Polarities { get; set; }
    }
}
