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

        void NavBar_AddProduct(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync( new NavigationPage( new AddProductPage() ));
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

        void TabBar_RecipesPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new RecipesPage());
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
                DisplayAlert("Hey!", "You have just changed device orientation. This feature is still in testing phase. We recommend you to use portait orientation, but it's not obligatory...", "ok");
        }

    }
}
