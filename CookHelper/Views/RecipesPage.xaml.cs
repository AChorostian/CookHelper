using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CookHelper.ViewModels;

namespace CookHelper.Views
{
    [DesignTimeVisible(true)]
    public partial class RecipesPage : ContentPage
    {
        RecipesViewModel viewModel;

        public RecipesPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RecipesViewModel();
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

        void NavBar_AddRecipe(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new AddRecipePage()));
        }

        void TabBar_ProductsPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ProductsPage());
        }

        void TabBar_RecipesPage(object sender, EventArgs e)
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
