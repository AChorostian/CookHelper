using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CookHelper.Models;

namespace CookHelper.Views
{
    [DesignTimeVisible(true)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Ustawienia");
        }

        void Setting_Tap(object sender, EventArgs e)
        {
            DisplayAlert("Tap", "Settings element", "ok");
        }

        void Units1_Tap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UnitsPage(UnitBase.Weight));
        }

        void Units2_Tap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UnitsPage(UnitBase.Volume));
        }

        void Units3_Tap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UnitsPage(UnitBase.Amount));
        }

        void TabBar_ProductsPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ProductsPage());
        }

        void TabBar_RecipesPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new RecipesPage());
        }

        void TabBar_SettingsPage(object sender, EventArgs e)
        {
            // you are here ;)
        }

    }
}
