namespace WarframeProgressTrackerApi.Models {
    public class UserCollectible {
        public string UserId { get; set; }
        public string ItemName { get; set; }
        public bool Mastered { get; set; } = false;
        public bool Obtained { get; set; } = false;
        public bool OnWishlist { get; set; } = false;
    }
}