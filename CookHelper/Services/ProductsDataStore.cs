using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookHelper.Models;

namespace CookHelper.Services
{
    public class ProductsDataStore : IDataStore<Product>
    {
        public List<Product> Products { get; set; }

        public ProductsDataStore()
        {
            Products = new List<Product>
            {
                new Product { Name="Mleko" },
                new Product { Name="Cukier" },
                new Product { Name="Masło" },
                new Product { Name="Mąka" },
                new Product { Name="Jajko" },
                new Product { Name="Sól" },
                new Product { Name="Woda" },
                new Product { Name="Śmietana" },
                new Product { Name="Jabłko" },
                new Product { Name="Ser" },
                new Product { Name="Czosnek" },
                new Product { Name="Olej" },
                new Product { Name="Cebula" },
                new Product { Name="Makaron kokardki" },
                new Product { Name="Makaron Spaghetti" },
            };
            Products.Sort();
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

        public List<Product> GetItems()
        {
            Products.Sort();
            return Products;
        }

    }
}
