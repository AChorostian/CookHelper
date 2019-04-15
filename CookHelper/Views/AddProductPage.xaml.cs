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
    public partial class AddProductPage : ContentPage
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        void NavBar_Cancel(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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
