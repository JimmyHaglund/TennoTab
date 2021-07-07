namespace WarframeProgressTrackerApi.Models {
    public class Frame {
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
    }
}
