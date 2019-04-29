using System.Collections.Generic;
using CookHelper.Models;
using CookHelper.Services;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CookHelper;

namespace CookHelper.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> ProductsCollection { get; set; }

        public ProductsViewModel()
        {
            //public IDataStore<Product> DataStore => DependencyService.Get<IDataStore<Product>>() ?? new ProductsDataStore();

            ProductsCollection = App.productsDataStore.GetItems();
        }
    }
}
