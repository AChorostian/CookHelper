using System.Collections.Generic;
using CookHelper.Models;

namespace CookHelper.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> ProductsCollection { get; set; }

        public ProductsViewModel()
        {
            ProductsCollection = new List<Product>
            {
                new Product { Name="Mleko" },
                new Product { Name="Cukier" },
                new Product { Name="Masło" },
                new Product { Name="Mąka" },
                new Product { Name="Jajko" },
                new Product { Name="Sól" },
                new Product { Name="Woda" },
            };

            ProductsCollection.Sort();
        }
    }
}
