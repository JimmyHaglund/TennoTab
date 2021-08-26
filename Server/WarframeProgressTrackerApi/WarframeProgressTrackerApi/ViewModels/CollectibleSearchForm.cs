namespace WarframeProgressTrackerApi.ViewModels {
    public class CollectibleSearchForm {
        public bool IncludeFrames { get; set; }
        public bool IncludePrimaryWeapons { get; set; }
        public bool IncludeSecondaryWeapons { get; set; }
        public bool IncludeMeleeWeapons { get; set; }
        public bool IncludePets { get; set; }
        public bool IncludeRoboWeapons { get; set; }
        public bool IncludeOperatorAmps { get; set; }
        public bool IncludeArchwings { get; set; }
        public bool IncludeArchGuns { get; set; }
        public bool IncludeArchMeleeWeapons { get; set; }

        public bool OnlyOnWishlist { get; set; } = false;
        public bool IncludeOwned { get; set; } = true;
        public bool IncludeMastered { get; set; } = true;

        public string SearchText { get; set; }
    }
}
