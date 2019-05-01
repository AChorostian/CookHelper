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
            viewModel.newUnit();
            UnitsLV.ItemsSource = viewModel.UnitsCollection;
        }




    }
}
