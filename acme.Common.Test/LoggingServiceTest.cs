using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Comon;
using System.Collections.Generic;
using ACM.BussinessLayer;

namespace acme.Common.Test
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changeItems = new List<ILoggable>();

            Customer customer = new Customer(1)
            {
                EmailAddress = "aidas@aidas.lt",
                FirstName = "Aidas",
                LastName = "Baranauskas",
                AddressList = null
            };
            
            changeItems.Add(customer as ILoggable);


            var product = new Product(2)
            {   //CustomerId=1,
                ProductName = "Sunflowers",
                ProductDescription = "Delicious sunflowers",
                CurrentPrice = 15.99M
            };
            changeItems.Add(product as ILoggable);

            LoggingService.WriteToFlie(changeItems);
        }
    }
}
