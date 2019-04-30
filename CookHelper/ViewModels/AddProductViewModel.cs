using System.Collections.Generic;
using CookHelper.Models;
using Xamarin.Forms;
using System;
using System.ComponentModel;

namespace CookHelper.ViewModels
{
    public class AddProductViewModel
    {
        public Product NewProduct { get; set; }

        public AddProductViewModel()
        {
            NewProduct = new Product();
        }

        public void SaveProduct()
        {
            if (NewProduct.Name != null)
                App.productsDataStore.AddItem(NewProduct);
        }
    }
}
