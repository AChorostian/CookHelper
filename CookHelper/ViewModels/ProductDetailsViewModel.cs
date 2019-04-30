using System.Collections.Generic;
using CookHelper.Models;
using CookHelper.Services;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CookHelper;

namespace CookHelper.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Product SelectedProduct { get; }

        public bool showSecond; // w przypadku gdy lista jednostek jest większa niż 1

        // lista jednostek

        // 2 domyślne jednostki

        public ProductDetailsViewModel(Product product)
        {
            SelectedProduct = product;
        }
    }
}
