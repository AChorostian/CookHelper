using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookHelper.Services
{
    public interface IDataStore<T>
    {
        void AddItem(T item);
        void UpdateItem(T item);
        void DeleteItem(int id);
        T    GetItem(int id);

        List<T> GetItems();
    }
}
