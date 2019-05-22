using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CookHelper.Services
{
    public interface IDataStore<T>
    {
        void AddItem(T item);
        void UpdateItem(T item);
        void DeleteItem(int id);
        T    GetItem(int id);

        ObservableCollection<T> GetItems();
    }
}
