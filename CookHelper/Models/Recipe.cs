using System;
using System.Collections.Generic;

namespace CookHelper.Models
{
    public class Recipe : IComparable<Recipe>
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public double Multiplier { get; set; }

        public List<Product> Products { get; set; }

        public int CompareTo(Recipe other) => Name.CompareTo(other.Name);
    }
}
