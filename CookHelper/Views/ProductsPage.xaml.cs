using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CookHelper.Views;
using CookHelper.ViewModels;
using CookHelper.Models;
using CookHelper.Services;

namespace CookHelper.Views
{
    public partial class ProductsPage : ContentPage
    {

        String searchText { get; set; }
        ProductsViewModel viewModel;

        public ProductsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ProductsViewModel();
            NavigationPage.SetBackButtonTitle(this, "Produkty");
        }

        async void NavBar_DefaultBar(object sender, System.EventArgs e)
        {
            searchBox.Unfocus();
            await Task.WhenAll(
                searchBar.TranslateTo(0, -44, 300, Easing.CubicOut),
                defaultBar.TranslateTo(0, 0, 300, Easing.CubicOut)
            );
        }

        async void NavBar_SearchBar(object sender, System.EventArgs e)
        {
            searchBox.Focus();
            await Task.WhenAll(
                searchBar.TranslateTo(0, 0, 300, Easing.CubicOut),
                defaultBar.TranslateTo(0, 44, 300, Easing.CubicOut)
            );
        }

        void searchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            ProductsLV.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                ProductsLV.ItemsSource = viewModel.ProductsCollection;
            else
                ProductsLV.ItemsSource = viewModel.ProductsCollection.Where(i => i.Name.Contains(e.NewTextValue));

            ProductsLV.EndRefresh();
        }

        void NavBar_AddProduct(object sender, System.EventArgs e)
        {
            Product product = new Product(); 
            Navigation.PushModalAsync( new NavigationPage( new AddProductPage(product) ));
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (!(args.SelectedItem is Product item))
                return;

            await Navigation.PushAsync(new ProductDetailsPage(item));

            ProductsLV.SelectedItem = null;
        }

        void TabBar_ProductsPage(object sender, EventArgs e)
        {
            // you are here ;)
        }

        void TabBar_SettingsPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new SettingsPage());
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            var orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();

            if (orientation == DeviceOrientations.Landscape)
                DisplayAlert("Hej!", "Właśnie obrócono ekran. Ta opcja jest nadal w fazie testowania. Zalecamy używać domyślnej orientacji.", "ok");
        }

    }
}
