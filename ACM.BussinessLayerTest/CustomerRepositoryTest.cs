using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BussinessLayer;
using System.Collections.Generic;

namespace ACM.BussinessLayerTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {   //CustomerId=1,
                EmailAddress = "aidas@aidas.lt",
                FirstName = "Aidas",
                LastName = "Baranauskas",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        StreetLine1 = "1502 truman ave.",
                        StreetLine2 = "",
                        City = "Key East",
                        StateProv = "FL",
                        PostalCode = "33031",
                        Country = "USA",
                        AddressType = 2
                    },
                    new Address()
                    {
                        StreetLine1 = "1522 truman ave.",
                        StreetLine2 = "",
                        City = "Key East",
                        StateProv = "NJ",
                        PostalCode = "33031",
                        Country = "USA",
                        AddressType = 1
                    }
                }

        };

            var actual = customerRepository.Retrieve(1);

            //Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StateProv, actual.AddressList[i].StateProv);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);


            }
        }
    }
}
