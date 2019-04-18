using System;
using System.Collections.ObjectModel;

namespace CookHelper.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        //public string ImageSource { get; set; }

        public string Description { get; set; }
        public double Multiplier { get; set; }

        public ObservableCollection<Product> Products { get; set; }
    }
}
