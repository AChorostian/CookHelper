using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookHelper.Models;

namespace CookHelper.Services
{
    public class ProductsDataStore : IDataStore<Product>
    {
        public List<Product> products { get; set; }

        public ProductsDataStore()
        {
            products = new List<Product>
            {
                new Product { Name="Mleko" , Image="Products/milk.png" },
                new Product { Name="Cukier" , Image="Products/sugar.png" },
                new Product { Name="Masło" , Image="Products/butter.png"},
                new Product { Name="Mąka" , Image="Products/flour.png"},
                new Product { Name="Jajko" , Image="Products/egg.png"},
                new Product { Name="Sól" , Image="Products/salt.png"},
                new Product { Name="Woda" , Image="Products/water.png"},
                new Product { Name="Śmietana" , Image="Products/sour_cream.png"},
                new Product { Name="Jabłko" , Image="Products/apple.png" },
                new Product { Name="Ser" , Image="Products/cheese.png" },
                new Product { Name="Czosnek" , Image="Products/garlic.png"},
                new Product { Name="Olej" , Image="Products/oil.png"},
                new Product { Name="Cebula" , Image="Products/onion.png"},
                new Product { Name="Makaron kokardki" , Image="Products/pasta1.png"},
                new Product { Name="Makaron Spaghetti" , Image="Products/pasta2.png"},
            };
            products.Sort();
        }

        public void AddItem(Product item)
        {
            products.Add(item);
        }

        public void UpdateItem(Product item)
        {
            var oldItem = products.Where((Product arg) => arg.Id == item.Id).FirstOrDefault();
            products.Remove(oldItem);
            products.Add(item);
        }

        public void DeleteItem(int id)
        {
            var oldItem = products.Where((Product arg) => arg.Id == id).FirstOrDefault();
            products.Remove(oldItem);
        }

        public Product GetItem(int id)
        {
            return products.FirstOrDefault(s => s.Id == id);
        }

        public List<Product> GetItems()
        {
            return products;
        }


    }
}
