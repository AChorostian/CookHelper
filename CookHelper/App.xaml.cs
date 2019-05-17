using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CookHelper.Views;
using CookHelper.Services;

namespace CookHelper
{
    public partial class App : Application
    {
        public static ProductsDataStore productsDataStore;
        public static UnitsDataStore unitsDataStore;

        public App()
        {
            InitializeComponent();
            productsDataStore = new ProductsDataStore();
            unitsDataStore = new UnitsDataStore();
            MainPage = new NavigationPage(new ProductsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }
}
