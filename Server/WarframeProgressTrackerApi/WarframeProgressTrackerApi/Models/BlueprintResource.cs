using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class BlueprintResource {
        public int ResultId { get; set; }
        public string ResultCategory { get; set; }

        public int ComponentId { get; set; }
        public string ComponentCategory { get; set; }
        public int ComponentCount { get; set; }

    }
}
