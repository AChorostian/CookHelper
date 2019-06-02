using NUnit.Framework;
using CookHelper.Models;
using CookHelper.ViewModels;
using CookHelper.Services;

namespace Tests
{
    public class ScenarioTest
    {
        ProductsViewModel productsViewModel;
        UnitsViewModel unitsViewModel;
        UnitsDataStore unitsDataStore;

        [SetUp]
        public void Setup()
        {
            IDataStore<Product> productsDataStore = new ProductsDataStore();
            productsViewModel = new ProductsViewModel(productsDataStore);

            unitsDataStore = new UnitsDataStore();
            unitsViewModel = new UnitsViewModel(UnitBase.Weight, unitsDataStore);
        }

        [Test]
        public void useAddedUnitTest()
        {
            Unit unit = new Unit { Name = "tona", Value = 1000000, Base = UnitBase.Weight };
            unitsViewModel.AddUnit(unit);

            Product cukier = productsViewModel.ProductsCollection[1];
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel(cukier,unitsDataStore);

            Unit gram = unitsViewModel.UnitsCollection[0];
            Unit tona = unitsViewModel.UnitsCollection[unitsViewModel.UnitsCollection.Count-1];

            productDetailsViewModel.UnitA = gram;
            productDetailsViewModel.UnitB = tona;
            productDetailsViewModel.ValueA = 1000000;

            productDetailsViewModel.CalculateB();

            Assert.AreEqual(1, productDetailsViewModel.ValueB);

        }
    }
}