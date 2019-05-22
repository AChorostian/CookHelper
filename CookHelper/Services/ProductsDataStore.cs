using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CookHelper.Models;

namespace CookHelper.Services
{
    public class ProductsDataStore : IDataStore<Product>
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductsDataStore()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Name="Mleko" , Weight=true , Volume=true , Amount=true , WeightValue=1000 , VolumeValue=1000 , AmountValue=1 },
                new Product { Name="Cukier" , Weight=true , Volume=true , Amount=true , WeightValue=1000 , VolumeValue=1250 , AmountValue=1 },
                new Product { Name="Masło" , Weight=true , Volume=true , WeightValue=240 , VolumeValue=250 },
                new Product { Name="Mąka" , Weight=true , Volume=true , WeightValue=170 , VolumeValue=250 },
                new Product { Name="Jajko" , Amount=true , AmountValue=1 },
                new Product { Name="Sól" , Weight=true , Volume=true , WeightValue=300 , VolumeValue=250 },
                new Product { Name="Woda" , Weight=true , Volume=true , WeightValue=250 , VolumeValue=250 },
                new Product { Name="Śmietana" , Weight=true , Volume=true , WeightValue=220 , VolumeValue=250 },
                new Product { Name="Jabłko" , Weight=true , Amount=true , WeightValue=180 , AmountValue=1 },
                new Product { Name="Ser" , Weight=true , WeightValue=100 },
                new Product { Name="Czosnek" , Weight=true , Amount=true , WeightValue=45 , AmountValue=1 },
                new Product { Name="Olej rzepakowy" , Weight=true , Volume=true , WeightValue=215 , VolumeValue=250 },
                new Product { Name="Cebula" , Weight=true , Amount=true , WeightValue=105 , AmountValue=1 },
                new Product { Name="Makaron kokardki" , Weight=true , Volume=true , WeightValue=75 , VolumeValue=250 },
                new Product { Name="Makaron Spaghetti" , Weight=true , WeightValue=100 },
                new Product { Name="Bułka tarta" , Weight=true , Volume=true , WeightValue=150 , VolumeValue=250 },
                new Product { Name="Miód" , Weight=true , Volume=true , WeightValue=360 , VolumeValue=250 }
            };
        }

        public void AddItem(Product item)
        {
            Products.Add(item);
        }

        public void UpdateItem(Product item)
        {
            var oldItem = Products.FirstOrDefault((Product arg) => arg.Id == item.Id);
            Products.Remove(oldItem);
            Products.Add(item);
        }

        public void DeleteItem(int id)
        {
            var oldItem = Products.FirstOrDefault((Product arg) => arg.Id == id);
            Products.Remove(oldItem);
        }

        public Product GetItem(int id)
        {
            return Products.FirstOrDefault(s => s.Id == id);
        }

        public ObservableCollection<Product> GetItems()
        {
            return Products;
        }

    }
}
