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

namespace CookHelper.Views
{
    [DesignTimeVisible(true)]
    public partial class AddProductPage : ContentPage
    {
        AddProductViewModel viewModel;

        public AddProductPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new AddProductViewModel();
        }

        void NavBar_Cancel(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        async void NavBar_Submit(object sender, EventArgs e)
        {
            viewModel.SaveProduct();
            await Navigation.PopModalAsync();
            App.Current.MainPage = new NavigationPage(new ProductsPage());
        }

        void first_Toggled(object sender, ToggledEventArgs e)
        {
            viewModel.NewProduct.Weight = e.Value;
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
        }

        void second_Toggled(object sender, ToggledEventArgs e)
        {
            viewModel.NewProduct.Volume = e.Value;
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
        }

        void third_Toggled(object sender, ToggledEventArgs e)
        {
            viewModel.NewProduct.Amount = e.Value;
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
