using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TheNaturalTouch.Models
{
    public class ProductFilterModel
    {

        public List<Product>? Products { get; set; }
        public SelectList? Categorys { get; set; }
        public string? ProductCategory { get; set; }
        public string? SearchString { get; set; }
    }
}
