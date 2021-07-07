using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class ArchMelee {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MasteryRankRequired { get; set; }
        public string HowToGet { get; set; } = "";

        public float RangeMetres { get; set; }
        public float AttackSpeed { get; set; }
    }
}
