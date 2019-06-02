using NUnit.Framework;
using CookHelper.Models;
using CookHelper.ViewModels;
using CookHelper.Services;

namespace Tests
{
    public class ValidationTest
    {
        ProductsViewModel productsViewModel;

        [SetUp]
        public void Setup()
        {
            IDataStore<Product> productsDataStore = new ProductsDataStore();
            productsViewModel = new ProductsViewModel(productsDataStore);
        }

        [Test]
        public void CorrectValidationTest()
        {
            Product cukier = new Product();

            cukier.Name = "Cukier trzcinowy";
            cukier.Id = 1;

            cukier.Weight = true;
            cukier.WeightValue = 100;

            cukier.Volume = true;
            cukier.VolumeValue = 80;

            AddProductViewModel addProduct = new AddProductViewModel(new Product());

            addProduct.NewProduct.Name = "Cukier trzcinowy";
            addProduct.NewProduct.Id = 1;

            addProduct.NewProduct.Weight = true;
            addProduct.StrWeightValue = "100";

            Assert.That(addProduct.SaveProductCommand.CanExecute(null));
        }

        [Test]
        public void IncorrectValidationTest()
        {
            Product cukier = new Product();

            cukier.Name = "Cukier trzcinowy";
            cukier.Id = 1;

            cukier.Weight = true;
            cukier.WeightValue = 100;

            cukier.Volume = true;
            cukier.VolumeValue = 80;

            AddProductViewModel addProduct = new AddProductViewModel(new Product());

            addProduct.NewProduct.Name = "Cukier trzcinowy";
            addProduct.NewProduct.Id = 1;

            addProduct.NewProduct.Weight = true;
            addProduct.StrWeightValue = "0";

            Assert.IsFalse(addProduct.SaveProductCommand.CanExecute(null));
        }
    }
}