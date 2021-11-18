﻿using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class InfestedSalvageMissionReward {
        [Key] public string ItemName { get; set; }
        [Key] public char Rotation { get; set; }
        public string MissionName { get; set; }
        public float DropChance { get; set; }
    }
}