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
                new Product { Name="Mleko" , Image="Products/milk.png" },
                new Product { Name="Cukier" , Image="Products/sugar.png" },
                new Product { Name="Masło" , Image="Products/butter.png"},
                new Product { Name="Mąka" , Image="Products/flour.png"},
                new Product { Name="Jajko" , Image="Products/egg.png"},
                new Product { Name="Sól" , Image="Products/salt.png"},
                new Product { Name="Woda" , Image="Products/water.png"},
                new Product { Name="Śmietana" , Image="Products/sour_cream.png"},
                new Product { Name="Jabłko" , Image="Products/apple.png" },
                new Product { Name="Ser" , Image="Products/cheese.png" },
                new Product { Name="Czosnek" , Image="Products/garlic.png"},
                new Product { Name="Olej" , Image="Products/oil.png"},
                new Product { Name="Cebula" , Image="Products/onion.png"},
                new Product { Name="Makaron kokardki" , Image="Products/pasta1.png"},
                new Product { Name="Makaron Spaghetti" , Image="Products/pasta2.png"},
            };

            ProductsCollection.Sort();
        }
    }
}
