using NUnit.Framework;
using CookHelper.Models;
using CookHelper.ViewModels;
using CookHelper.Services;

namespace Tests
{
    public class ViewModelTest
    {
        ProductsViewModel productsViewModel;
        UnitsViewModel unitsViewModel;

        [SetUp]
        public void Setup()
        {
            IDataStore<Product> productsDataStore = new ProductsDataStore();
            productsViewModel = new ProductsViewModel(productsDataStore);

            IDataStore<Unit> unitsDataStore = new UnitsDataStore();
            unitsViewModel = new UnitsViewModel(UnitBase.Weight,unitsDataStore);
        }

        [Test]
        public void WeightUnitsViewModelTest()
        {
            Assert.AreEqual("Jednostki wagi", unitsViewModel.Title);
        }


        [Test]
        public void CorrectCreateProductsDataStore()
        {
            Assert.AreEqual(17, productsViewModel.ProductsCollection.Count);
        }

        [Test]
        public void CorrectCreateUnitsWeightDataStore()
        {
            Assert.AreEqual(3, unitsViewModel.UnitsCollection.Count);
        }


    }
}