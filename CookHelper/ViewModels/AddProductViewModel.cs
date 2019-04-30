using System.Collections.Generic;
using CookHelper.Models;
using Xamarin.Forms;
using System;
using System.ComponentModel;

namespace CookHelper.ViewModels
{
    public class AddProductViewModel
    {
        public Product NewProduct { get; set; }

        public string StrWeightValue
        {
            get { if (NewProduct.WeightValue != 0) return NewProduct.WeightValue.ToString(); else return null; }
            set
            {
                try
                { NewProduct.WeightValue = Convert.ToDouble(value); }
                catch (FormatException) {}
                catch (OverflowException) {}
            }
        }

        public string StrVolumeValue
        {
            get { if (NewProduct.WeightValue != 0) return NewProduct.WeightValue.ToString(); else return null; }
            set
            {
                try
                { NewProduct.WeightValue = Convert.ToDouble(value); }
                catch (FormatException) { }
                catch (OverflowException) { }
            }
        }

        public string StrAmountValue
        {
            get { if (NewProduct.WeightValue != 0) return NewProduct.WeightValue.ToString(); else return null; }
            set
            {
                try
                { NewProduct.WeightValue = Convert.ToDouble(value); }
                catch (FormatException) { }
                catch (OverflowException) { }
            }
        }

        public AddProductViewModel()
        {
            NewProduct = new Product();
        }

        public void SaveProduct()
        {
            if (NewProduct.Name != null)
                App.productsDataStore.AddItem(NewProduct);
        }
    }
}
