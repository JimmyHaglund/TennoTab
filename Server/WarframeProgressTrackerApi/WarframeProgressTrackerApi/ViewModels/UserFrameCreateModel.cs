using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeProgressTrackerApi.ViewModels {
    public class UserFrameCreateModel {
        public int FrameId { get; set; }
        public int MasteryRank { get; set; } = 0;
        public bool Obtained { get; set; } = false;
    }
}