using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class Frame {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Shield { get; set; }
        public int Armor { get; set; }
        public int Energy { get; set; }
        public float SprintSpeed { get; set; }
        public string Polarities { get; set; }
        public string ExilusPolarity { get; set; }
        public string AuraPolarity { get; set; }
        public int SubsumedAbility { get; set; }
    }
}
