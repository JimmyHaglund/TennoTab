using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class BlueprintResource {
        public string ResultName { get; set; }
        public string ComponentName { get; set; }

        public string ResultCategory { get; set; }
        public string ComponentCategory { get; set; }
        public int ComponentCount { get; set; }

    }
}
