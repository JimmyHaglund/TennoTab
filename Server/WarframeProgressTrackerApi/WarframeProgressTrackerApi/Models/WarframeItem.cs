using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.Models {
    public abstract class WarframeItem {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
