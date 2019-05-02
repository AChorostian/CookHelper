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

        void ValueA_PropertyChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            viewModel.CalculateB();
            ValB.Text = viewModel.ValueB.ToString();
        }
        void ValueB_PropertyChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            viewModel.CalculateA();
            ValA.Text = viewModel.ValueA.ToString();
        }
        void UnitA_PropertyChanged(object sender, System.EventArgs e)
        {
            viewModel.CalculateB();
            ValB.Text = viewModel.ValueB.ToString();
        }
        void UnitB_PropertyChanged(object sender, System.EventArgs e)
        {
            viewModel.CalculateB();
            ValB.Text = viewModel.ValueB.ToString();
        }
    }
}
