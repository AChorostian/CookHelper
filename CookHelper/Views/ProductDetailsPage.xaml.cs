using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Plugin.Media;

using CookHelper.ViewModels;
using CookHelper.Models;

namespace CookHelper.Views
{
    [DesignTimeVisible(true)]
    public partial class ProductDetailsPage : ContentPage
    {
        ProductDetailsViewModel viewModel;

        public ProductDetailsPage(Product product)
        {
            InitializeComponent();
            BindingContext = viewModel = new ProductDetailsViewModel(product);
        }

    }
}
