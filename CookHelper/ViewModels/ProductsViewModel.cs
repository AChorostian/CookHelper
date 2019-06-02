using System.Collections.Generic;
using CookHelper.Models;
using CookHelper.Services;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CookHelper;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace CookHelper.ViewModels
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Product> ProductsCollection { get; set; }

        public ProductsViewModel()
        {
            ProductsCollection = App.productsDataStore.GetItems();

        }

        public ProductsViewModel(IDataStore<Product> dataStore)
        {
            ProductsCollection = dataStore.GetItems();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
