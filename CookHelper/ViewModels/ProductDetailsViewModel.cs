using System.Collections.Generic;
using CookHelper.Models;
using CookHelper.Services;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CookHelper;

namespace CookHelper.ViewModels
{
    public class ProductDetailsViewModel
    {
        public Product SelectedProduct { get; set; }
        public List<Unit> Units { get; set; }

        public double ValueA { get; set; }
        public double ValueB { get; set; }
        public Unit UnitA { get; set; }
        public Unit UnitB { get; set; }

        public ProductDetailsViewModel(Product product)
        {
            SelectedProduct = product;
            Units = new List<Unit>();

            if (SelectedProduct.Weight)
                Units.AddRange(App.unitsDataStore.GetItems(UnitBase.Weight));
            if (SelectedProduct.Volume)
                Units.AddRange(App.unitsDataStore.GetItems(UnitBase.Volume));
            if (SelectedProduct.Amount)
                Units.AddRange(App.unitsDataStore.GetItems(UnitBase.Amount));

            ValueA = 0;
            UnitA = Units[0];
            ValueB = 0;
            UnitB = Units[1];
        }

        public ProductDetailsViewModel(Product product, IDataStore<Unit> dataStore)
        {
            SelectedProduct = product;
            Units = new List<Unit>();

            if (SelectedProduct.Weight)
                Units.AddRange((dataStore as UnitsDataStore).GetItems(UnitBase.Weight));
            if (SelectedProduct.Volume)
                Units.AddRange((dataStore as UnitsDataStore).GetItems(UnitBase.Volume));
            if (SelectedProduct.Amount)
                Units.AddRange((dataStore as UnitsDataStore).GetItems(UnitBase.Amount));

            ValueA = 0;
            UnitA = Units[0];
            ValueB = 0;
            UnitB = Units[1];
        }

        public void CalculateA()
        {
            double baseValueB = ValueB * UnitB.Value;

            if (UnitA.Base == UnitB.Base)
            {
                ValueA = baseValueB / UnitA.Value;
            }
            else
            {
                double baseValueA=0;
                switch (UnitB.Base)
                {
                    case UnitBase.Weight:
                        if (UnitA.Base == UnitBase.Volume)
                            baseValueA = (baseValueB * SelectedProduct.VolumeValue) / SelectedProduct.WeightValue;
                        if (UnitA.Base == UnitBase.Amount)
                            baseValueA = (baseValueB * SelectedProduct.AmountValue) / SelectedProduct.WeightValue;
                        break;
                    case UnitBase.Volume:
                        if (UnitA.Base == UnitBase.Weight)
                            baseValueA = (baseValueB * SelectedProduct.WeightValue) / SelectedProduct.VolumeValue;
                        if (UnitA.Base == UnitBase.Amount)
                            baseValueA = (baseValueB * SelectedProduct.AmountValue) / SelectedProduct.VolumeValue;
                        break;
                    case UnitBase.Amount:
                        if (UnitA.Base == UnitBase.Volume)
                            baseValueA = (baseValueB * SelectedProduct.VolumeValue) / SelectedProduct.AmountValue;
                        if (UnitA.Base == UnitBase.Weight)
                            baseValueA = (baseValueB * SelectedProduct.WeightValue) / SelectedProduct.AmountValue;
                        break;
                }
                ValueA = baseValueA / UnitA.Value;
            }
        }

        public void CalculateB()
        {
            double baseValueA = ValueA * UnitA.Value;

            if (UnitB.Base == UnitA.Base)
            {
                ValueB = baseValueA / UnitB.Value;
            }
            else
            {
                double baseValueB = 0;
                switch (UnitA.Base)
                {
                    case UnitBase.Weight:
                        if (UnitB.Base == UnitBase.Volume)
                            baseValueB = (baseValueA * SelectedProduct.VolumeValue) / SelectedProduct.WeightValue;
                        if (UnitB.Base == UnitBase.Amount)
                            baseValueB = (baseValueA * SelectedProduct.AmountValue) / SelectedProduct.WeightValue;
                        break;
                    case UnitBase.Volume:
                        if (UnitB.Base == UnitBase.Weight)
                            baseValueB = (baseValueA * SelectedProduct.WeightValue) / SelectedProduct.VolumeValue;
                        if (UnitB.Base == UnitBase.Amount)
                            baseValueB = (baseValueA * SelectedProduct.AmountValue) / SelectedProduct.VolumeValue;
                        break;
                    case UnitBase.Amount:
                        if (UnitB.Base == UnitBase.Volume)
                            baseValueB = (baseValueA * SelectedProduct.VolumeValue) / SelectedProduct.AmountValue;
                        if (UnitB.Base == UnitBase.Weight)
                            baseValueB = (baseValueA * SelectedProduct.WeightValue) / SelectedProduct.AmountValue;
                        break;
                }
                ValueB = baseValueB / UnitB.Value;
            }
        }

    }
}
