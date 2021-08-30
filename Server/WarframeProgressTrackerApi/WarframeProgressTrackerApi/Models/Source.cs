using System.ComponentModel.DataAnnotations;
namespace WarframeProgressTrackerApi.Models {
    public class Source {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string SourceName { get; set; }
        public string SourceType { get; set; }
        public string Value { get; set; }
    }
}
