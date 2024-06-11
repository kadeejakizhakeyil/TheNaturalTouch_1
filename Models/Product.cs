using System.ComponentModel.DataAnnotations;
namespace TheNaturalTouch.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Image { get; set; }
        public string? Material { get; set; }
        [Display(Name = "Fabric Type")]
        public string? FabricType { get; set; }
        public string? Pattern { get; set; }
        public string? Style { get; set; }
        public string? Theme { get; set; }
        public string? Shape { get; set; }
        public string? Feature { get; set; }

    }
}
