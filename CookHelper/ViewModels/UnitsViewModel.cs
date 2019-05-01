using System.Collections.Generic;
using CookHelper.Models;
using CookHelper.Services;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CookHelper;

namespace CookHelper.ViewModels
{
    public class UnitsViewModel
    {
        //public List<Product> ProductsCollection { get; set; }
        public string Title { get; set; }

        public UnitsViewModel(UnitBase unitBase)
        {
            switch (unitBase)
            {
                case UnitBase.Weight:
                    Title = "Jednostki wagi";
                    break;
                case UnitBase.Volume:
                    Title = "Jednostki objętości";
                    break;
                case UnitBase.Amount:
                    Title = "ilości sztuk";
                    break;
                default:
                    break;
            }

            //ProductsCollection = App.productsDataStore.GetItems();
        }
    }
}