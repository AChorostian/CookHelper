using NUnit.Framework;
using CookHelper.Models;

namespace Tests
{
    public class ModelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductModelTest()
        {
            Product product = new Product();

            product.Id = 1;
            product.Name = "Cukier";

            Assert.Multiple(() =>
            {
                Assert.IsFalse(product.Weight);
                Assert.IsFalse(product.Amount);
                Assert.IsFalse(product.Volume);

                Assert.AreEqual("Cukier", product.Name);
                Assert.AreNotEqual(0, product.Id);
            });
        }

        [Test]
        public void UnitModelTest()
        {
            Unit unit = new Unit();

            unit.Id = 1;
            unit.Name = "dekagram";
            unit.Base = UnitBase.Weight;
            unit.Value = 10;

            Assert.Multiple(() =>
            {
                Assert.AreEqual("dekagram", unit.Name);
                Assert.AreEqual(UnitBase.Weight, unit.Base);
                Assert.AreEqual(10, unit.Value);
                Assert.AreNotEqual(0, unit.Id);
            });
        }
    }
}