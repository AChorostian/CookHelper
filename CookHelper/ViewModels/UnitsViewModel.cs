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
        public IEnumerable<Unit> UnitsCollection { get; set; }
        public string Title { get; set; }

        public UnitBase unitBase;

        public UnitsViewModel(UnitBase unitBase)
        {
            this.unitBase = unitBase;

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

            UnitsCollection = App.unitsDataStore.GetItems(unitBase);
        }

        public void newUnit()
        {
            Unit unit = new Unit { Name="Nowa jednostka" , Value=1 , Base = unitBase };
            App.unitsDataStore.AddItem(unit);
            UnitsCollection = App.unitsDataStore.GetItems(unitBase);
        }
    }
}