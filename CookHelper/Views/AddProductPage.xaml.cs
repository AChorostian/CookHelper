using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Plugin.Media;

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
        }

        async void Picture_Tap(object sender, EventArgs e)
        {

            await CrossMedia.Current.Initialize();

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync();
            Pic.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());
        }
    }
}
