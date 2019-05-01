using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookHelper.Models;

namespace CookHelper.Services
{
    public class UnitsDataStore : IDataStore<Unit>
    {
        public List<Unit> Units { get; set; }

        public UnitsDataStore()
        {
            Units = new List<Unit>
            {
                new Unit { Name="gram" , Base=UnitBase.Weight , Value=1 },
                new Unit { Name="kilogram" , Base=UnitBase.Weight , Value=1000 },

                new Unit { Name="mililitr" , Base=UnitBase.Volume , Value=1 },
                new Unit { Name="litr" , Base=UnitBase.Volume , Value=1000 },
                new Unit { Name="szklanka" , Base=UnitBase.Volume , Value=250 },
                new Unit { Name="łyżka" , Base=UnitBase.Volume , Value=15 },
                new Unit { Name="łyżeczka" , Base=UnitBase.Volume , Value=5 },

                new Unit { Name="sztuka" , Base=UnitBase.Amount , Value=1 },
                new Unit { Name="tuzin" , Base=UnitBase.Amount , Value=12 },
                new Unit { Name="kopa" , Base=UnitBase.Amount , Value=60 }
            };
            Units.Sort();
        }

        public void AddItem(Unit item)
        {
            Units.Add(item);
        }

        public void UpdateItem(Unit item)
        {
            var oldItem = Units.FirstOrDefault((Unit arg) => arg.Id == item.Id);
            Units.Remove(oldItem);
            Units.Add(item);
        }

        public void DeleteItem(int id)
        {
            var oldItem = Units.FirstOrDefault((Unit arg) => arg.Id == id);
            Units.Remove(oldItem);
        }

        public Unit GetItem(int id)
        {
            return Units.FirstOrDefault(s => s.Id == id);
        }

        public List<Unit> GetItems()
        {
            Units.Sort();
            return Units;
        }

        public List<Unit> GetItems(UnitBase unitBase)
        {
            Units.Sort();
            return (List<Unit>)Units.Where(u => u.Base == unitBase);
        }

    }
}
