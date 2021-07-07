using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarframeProgressTrackerApi.Models;

namespace WarframeProgressTrackerApi.ViewModels {
    public class UserFrameData {
        public UserFrameData() { }
        public UserFrameData(Frame frame) {
            Id = frame.Id;
            MasteryRankRequired = frame.MasteryRankRequired;
            Name = frame.Name;
            Health = frame.Health;
            HealthMaxFactor = frame.HealthMaxFactor;
            Shield = frame.Shield;
            ShieldMaxFactor = frame.ShieldMaxFactor;
            Armor = frame.Armor;
            ArmorMaxFactor = frame.ArmorMaxFactor;
            Energy = frame.Energy;
            EnergyMaxFactor = frame.EnergyMaxFactor;
            SprintSpeed = frame.SprintSpeed;
            Polarities = frame.Polarities;
            ExilusPolarity = frame.ExilusPolarity;
            AuraPolarity = frame.AuraPolarity;
            SubsumedAbility = frame.SubsumedAbility;
            HowToGet = frame.HowToGet;
        }

        public int Id { get; set; }
        public int MasteryRankRequired { get; set; } = 0;
        public string Name { get; set; }
        public int Health { get; set; }
        public float HealthMaxFactor { get; set; } = 3.0f;
        public int Shield { get; set; }
        public float ShieldMaxFactor { get; set; } = 3.0f;
        public int Armor { get; set; }
        public float ArmorMaxFactor { get; set; } = 1.0f;
        public int Energy { get; set; }
        public float EnergyMaxFactor { get; set; } = 1.5f;
        public float SprintSpeed { get; set; }
        public string Polarities { get; set; }
        public string ExilusPolarity { get; set; } = "";
        public string AuraPolarity { get; set; }
        public int SubsumedAbility { get; set; }
        public string HowToGet { get; set; } = "";


        public int MasteryRank { get; set; } = 0;
        public bool Obtained { get; set; } = false;
    }
}
