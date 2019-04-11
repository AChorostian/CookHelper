using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CookHelper.Views
{
    [DesignTimeVisible(true)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
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
            // todo switch page to AddProductPage here
            DisplayAlert("Switch page", "AddProductPage", "ok");
        }

        void TabBar_ProductsPage(object sender, EventArgs e)
        {
            // todo switch page to ProductsPage here
            DisplayAlert("Switch page", "ProductsPage", "ok");
        }

        void TabBar_RecipesPage(object sender, EventArgs e)
        {
            // todo switch page to RecipesPage here
            DisplayAlert("Switch page", "RecipesPage", "ok");
        }

        void TabBar_SettingsPage(object sender, EventArgs e)
        {
            // todo switch page to SettingsPage here
            DisplayAlert("Switch page", "SettingsPage", "ok");
        }

    }
}
