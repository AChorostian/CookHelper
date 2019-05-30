using NUnit.Framework;
using CookHelper.Models;
using CookHelper.ViewModels;

namespace Tests
{
    public class ViewModelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WeightUnitsViewModelTest()
        {
            UnitsViewModel viewModel = new UnitsViewModel(UnitBase.Weight);

            Assert.AreEqual("Jednostki wagi", viewModel.Title);
        }
    }
}