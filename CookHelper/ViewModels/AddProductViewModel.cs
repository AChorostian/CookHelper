using System.Collections.Generic;
using CookHelper.Models;
using Xamarin.Forms;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace CookHelper.ViewModels
{
    public class AddProductViewModel
    {
        public ICommand SaveProductCommand { get; private set; }

        public Product NewProduct { get; set; }

        public AddProductViewModel()
        {
            NewProduct = new Product();
            NewProduct.WeightValue = 0;
            NewProduct.VolumeValue = 0;
            NewProduct.AmountValue = 0;

            SaveProductCommand = new Command(
                execute: ()=>
                {
                    App.productsDataStore.AddItem(NewProduct);
                },
                canExecute: ()=>
                {
                    if (NewProduct.Name == null) return false;
                    if (NewProduct.Name.Equals("")) return false;
                    if (NewProduct.Name.Length > 50) return false;

                    if (NewProduct.Weight && NewProduct.WeightValue <= 0) return false;
                    if (NewProduct.Amount && NewProduct.AmountValue <= 0) return false;
                    if (NewProduct.Volume && NewProduct.VolumeValue <= 0) return false;

                    if (!NewProduct.Weight && !NewProduct.Amount && !NewProduct.Volume) return false;

                    return true;
                }
            );
        }

        public void RefreshCommand()
        {
            (SaveProductCommand as Command).ChangeCanExecute();
        }

        public string StrWeightValue
        {
            get
            { 
                if (NewProduct.WeightValue != 0)
                {
                    return NewProduct.WeightValue.ToString();
                }
                else
                    return null; }
            set
            {
                if (value!= null)
                {
                    if (value.Equals(""))
                        NewProduct.WeightValue = 0;
                }
                try
                { NewProduct.WeightValue = Convert.ToDouble(value); }
                catch (FormatException) {}
                catch (OverflowException) {}
                (SaveProductCommand as Command).ChangeCanExecute();
            }
        }

        public string StrVolumeValue
        {
            get { if (NewProduct.VolumeValue != 0) return NewProduct.VolumeValue.ToString(); else return null; }
            set
            {
                if (value != null)
                {
                    if (value.Equals(""))
                        NewProduct.VolumeValue = 0;
                }
                try
                { NewProduct.VolumeValue = Convert.ToDouble(value); }
                catch (FormatException) { }
                catch (OverflowException) { }
                (SaveProductCommand as Command).ChangeCanExecute();
            }
        }

        public string StrAmountValue
        {
            get { if (NewProduct.AmountValue != 0) return NewProduct.AmountValue.ToString(); else return null; }
            set
            {
                if (value != null)
                {
                    if (value.Equals(""))
                        NewProduct.AmountValue = 0;
                }
                try
                { NewProduct.AmountValue = Convert.ToDouble(value); }
                catch (FormatException) {}
                catch (OverflowException) {}
                (SaveProductCommand as Command).ChangeCanExecute();
            }
        }
    }
}
