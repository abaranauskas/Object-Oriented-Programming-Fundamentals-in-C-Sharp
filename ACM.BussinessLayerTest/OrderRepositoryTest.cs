using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BussinessLayer;
using System.Collections.Generic;

namespace ACM.BussinessLayerTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExistingOrder()
        {
            OrderRepository orderRepository = new OrderRepository();

            var expected1 = new OrderDisplay()
            {
                FirstName = "Aidas",
                LastName = "Baranauskas",
                OrderDate = new DateTimeOffset(2018, 5, 1, 8, 6, 32, 545,
                                 new TimeSpan(1, 0, 0)),
                ShippingAdress = new Address()
                {
                    StreetLine1 = "1501 truman ave.",
                    StreetLine2 = "",
                    City = "Key west",
                    StateProv = "FL",
                    PostalCode = "33030",
                    Country = "US",
                    AddressType = 1
                },
                orderDisplayList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchachePrice = 15.99M,
                        OrderQuantity = 3
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchachePrice = 1.99M,
                        OrderQuantity = 2
                    }
                }
            };           
            

           

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2008, 5, 1, 8, 6, 32, 545,
                                 new TimeSpan(1, 0, 0))
            };

            var actual = orderRepository.Retrieve(10);
            var actual1 = orderRepository.RetrieveOrderDisplay(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected1.FirstName, actual1.FirstName);
            Assert.AreEqual(expected1.LastName, actual1.LastName);
            Assert.AreEqual(expected1.OrderDate, actual1.OrderDate);

            Assert.AreEqual(expected1.ShippingAdress.AddressType, actual1.ShippingAdress.AddressType);
            Assert.AreEqual(expected1.ShippingAdress.StreetLine1, actual1.ShippingAdress.StreetLine1);
            Assert.AreEqual(expected1.ShippingAdress.City, actual1.ShippingAdress.City);
            Assert.AreEqual(expected1.ShippingAdress.StateProv, actual1.ShippingAdress.StateProv);
            Assert.AreEqual(expected1.ShippingAdress.Country, actual1.ShippingAdress.Country);
            Assert.AreEqual(expected1.ShippingAdress.PostalCode, actual1.ShippingAdress.PostalCode);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected1.orderDisplayList[i].ProductName, actual1.orderDisplayList[i].ProductName);
                Assert.AreEqual(expected1.orderDisplayList[i].OrderQuantity, actual1.orderDisplayList[i].OrderQuantity);
                Assert.AreEqual(expected1.orderDisplayList[i].PurchachePrice, actual1.orderDisplayList[i].PurchachePrice);
            }

        }
    }
}
