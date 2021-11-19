namespace WarframeProgressTrackerApi.ViewModels {
    public class CollectibleView {
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public bool Obtained { get; set; } = false;
        public bool Mastered { get; set; } = false;
        public bool OnWishlist { get; set; } = false;
    }
}
