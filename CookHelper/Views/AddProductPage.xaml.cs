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
    public partial class AddProductPage : ContentPage
    {
        AddProductViewModel viewModel;

        public AddProductPage( Product product )
        {
            InitializeComponent();
            BindingContext = viewModel = new AddProductViewModel( product );
        }

        void NavBar_Cancel(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        async void NavBar_Submit(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
            App.Current.MainPage = new NavigationPage(new ProductsPage());
        }

        void ProductNameChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            viewModel.RefreshCommand();
        }

        void first_Toggled(object sender, ToggledEventArgs e)
        {
            double small = 42;
            double big = 84.5;
            if (e.Value)
            {
                var animation = new Animation(v => first.HeightRequest = v, small, big);
                animation.Commit(this, "SimpleAnimation", 16, 300, Easing.CubicInOut, (v, c) => first.HeightRequest = big);
            }
            else
            {
                var animation = new Animation(v => first.HeightRequest = v, big, small);
                animation.Commit(this, "SimpleAnimation", 16, 300, Easing.CubicInOut, (v, c) => first.HeightRequest = small);
            }
            viewModel.RefreshCommand();
        }

        void second_Toggled(object sender, ToggledEventArgs e)
        {
            double small = 42;
            double big = 84.5;
            if (e.Value)
            {
                var animation = new Animation(v => second.HeightRequest = v, small, big);
                animation.Commit(this, "SimpleAnimation", 16, 300, Easing.CubicInOut, (v, c) => second.HeightRequest = big);
            }
            else
            {
                var animation = new Animation(v => second.HeightRequest = v, big, small);
                animation.Commit(this, "SimpleAnimation", 16, 300, Easing.CubicInOut, (v, c) => second.HeightRequest = small);
            }
            viewModel.RefreshCommand();
        }

        void third_Toggled(object sender, ToggledEventArgs e)
        {
            double small = 42;
            double big = 84.5;
            if (e.Value)
            {
                var animation = new Animation(v => third.HeightRequest = v, small, big);
                animation.Commit(this, "SimpleAnimation", 16, 300, Easing.CubicInOut, (v, c) => third.HeightRequest = big);
            }
            else
            {
                var animation = new Animation(v => third.HeightRequest = v, big, small);
                animation.Commit(this, "SimpleAnimation", 16, 300, Easing.CubicInOut, (v, c) => third.HeightRequest = small);
            }
            viewModel.RefreshCommand();
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
