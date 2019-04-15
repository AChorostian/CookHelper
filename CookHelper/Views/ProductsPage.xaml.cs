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
            Navigation.PushModalAsync( new NavigationPage( new AddProductPage() ));
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

    }
}
