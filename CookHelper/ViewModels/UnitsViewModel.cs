using System.Collections.Generic;
using System.Collections.ObjectModel;
using CookHelper.Models;
using CookHelper.Services;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CookHelper;

namespace CookHelper.ViewModels
{
    public class UnitsViewModel
    {
        private IDataStore<Unit> dataStore;
        public ObservableCollection<Unit> UnitsCollection { get; set; }
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

            dataStore = App.unitsDataStore;
            UnitsCollection = (dataStore as UnitsDataStore).GetItems(unitBase);
        }

        public UnitsViewModel(UnitBase unitBase , IDataStore<Unit> dataStore)
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

            this.dataStore = dataStore;
            UnitsCollection = (dataStore as UnitsDataStore).GetItems(unitBase);
        }

        public void AddUnit()
        {
            Unit unit = new Unit { Name="Nowa jednostka" , Value=1 , Base = unitBase };
            dataStore.AddItem(unit);
            UnitsCollection = (dataStore as UnitsDataStore).GetItems(unitBase);
        }
        public void AddUnit(Unit unit)
        {
            dataStore.AddItem(unit);
            UnitsCollection = (dataStore as UnitsDataStore).GetItems(unitBase);
        }

        public void DeleteUnit(int id)
        {
            dataStore.DeleteItem(id);
            UnitsCollection = (dataStore as UnitsDataStore).GetItems(unitBase);
        }
    }
}