using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.ViewModels {
    public class Blueprint {
        public string ResultName { get; set; }
        public IEnumerable<ComponentStack> Components { get; set; }
    }
}
