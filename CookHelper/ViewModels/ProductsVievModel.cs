using System;
using System.Collections.ObjectModel;

using CookHelper.Views;
using CookHelper.ViewModels;
using CookHelper.Models;


namespace CookHelper.ViewModels
{
    public class ProductsViewModel
    {
        public ObservableCollection<Product> ProductsCollection { get; set; }

        public ProductsViewModel()
        {
            ProductsCollection = new ObservableCollection<Product>
            {
                new Product { Name="Mleko" },
                new Product { Name="Cukier" },
                new Product { Name="Masło" },
                new Product { Name="Mąka" },
                new Product { Name="Jajko" },
                new Product { Name="Sól" },
                new Product { Name="Woda" },
            };
        }
    }
}
