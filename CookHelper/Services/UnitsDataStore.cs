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
        public int nextId { get; set; }

        public UnitsDataStore()
        {
            Units = new List<Unit>
            {
                new Unit { Id=0 , Name="gram" , Base=UnitBase.Weight , Value=1 },
                new Unit { Id=1 , Name="dekagram" , Base=UnitBase.Weight , Value=10 },
                new Unit { Id=2 , Name="kilogram" , Base=UnitBase.Weight , Value=1000 },

                new Unit { Id=3 , Name="mililitr" , Base=UnitBase.Volume , Value=1 },
                new Unit { Id=4 , Name="litr" , Base=UnitBase.Volume , Value=1000 },
                new Unit { Id=5 , Name="szklanka" , Base=UnitBase.Volume , Value=250 },
                new Unit { Id=6 , Name="łyżka" , Base=UnitBase.Volume , Value=15 },
                new Unit { Id=7 , Name="łyżeczka" , Base=UnitBase.Volume , Value=5 },

                new Unit { Id=8 , Name="sztuka" , Base=UnitBase.Amount , Value=1 },
                new Unit { Id=9 , Name="tuzin" , Base=UnitBase.Amount , Value=12 }
            };
            Units.Sort();
            nextId = 10;
        }

        public void AddItem(Unit item)
        {
            item.Id = nextId++;
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

        public IEnumerable<Unit> GetItems(UnitBase unitBase)
        {
            Units.Sort();
            return Units.Where(u => u.Base == unitBase);
        }

    }
}
