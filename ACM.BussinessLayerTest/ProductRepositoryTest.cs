using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BussinessLayer;

namespace ACM.BussinessLayerTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveExistingProduct()
        {
            var ProductRepository = new ProductRepository();
            var expected = new Product(2)
            {   //CustomerId=1,
                ProductName = "Sunflowers",
                ProductDescription = "Delicious sunflowers",
                CurrentPrice = 15.99M

            };

            var actual = ProductRepository.Retrieve(2);

            Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
