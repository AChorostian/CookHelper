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
    public partial class UnitsPage : ContentPage
    {
        UnitsViewModel viewModel;

        public UnitsPage(UnitBase unitBase)
        {
            InitializeComponent();
            BindingContext = viewModel = new UnitsViewModel(unitBase);
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            UnitsLV.SelectedItem = null;
        }

        void AddUnit(object sender, System.EventArgs e)
        {
            viewModel.AddUnit();
            UnitsLV.ItemsSource = viewModel.UnitsCollection;
        }

        async void DeleteUnit(object sender, EventArgs e)
        {
            if (await DisplayAlert("Uwaga", "Czy na pewno chcesz usunąć tą jednostkę", "usuń" , "anuluj" ))
            {
                viewModel.DeleteUnit(int.Parse((sender as Button).CommandParameter.ToString()));
                UnitsLV.ItemsSource = viewModel.UnitsCollection;
            }
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
