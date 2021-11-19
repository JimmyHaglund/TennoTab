namespace WarframeProgressTrackerApi.Models {
    public class BountyReward {
        public string ItemName { get; set; }
        public string Location { get; set; }
        public char Rotation { get; set; }
        public byte BountyTier { get; set; }
        public byte BountyStage { get; set; }
        public float DropChance { get; set; }
    }
}
