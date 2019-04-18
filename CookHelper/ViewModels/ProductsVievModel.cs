using System;
using System.Collections.ObjectModel;

using CookHelper.Views;
using CookHelper.ViewModels;
using CookHelper.Models;


namespace CookHelper.ViewModels
{
    public class ProductsViewModel
    {
        public ObservableCollection<Product> Items { get; set; }

        public ProductsViewModel()
        {
            Items = new ObservableCollection<Product>();

            Items.Add(new Product("nazwa1"));
            Items.Add(new Product("nazwa2"));
            Items.Add(new Product("nazwa3"));
        }
    }
}
