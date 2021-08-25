using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public class Blueprint {
        // Foreign key of resulting item
        public int ResultId { get; set; }
        public IEnumerable<BlueprintResource> BlueprintResources { get; set; }
    }
}
