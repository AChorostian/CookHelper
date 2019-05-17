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
    public partial class AddRecipePage : ContentPage
    {
        public AddRecipePage()
        {
            InitializeComponent();
        }

        void NavBar_Cancel(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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
