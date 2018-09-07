using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BussinessLayer;

namespace ACM.BussinessLayerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {

            //--Arrage
            Customer customer = new Customer();
            customer.FirstName = "Aidas";
            customer.LastName = "Baranauskas";

            string expected = "Baranauskas, Aidas";
            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void FullNameFisrtNameEmpty()
        {

            //--Arrage
            Customer customer = new Customer();
            //customer.FirstName = "Aidas";
            customer.LastName = "Baranauskas";

            string expected = "Baranauskas";
            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {

            //--Arrage
            Customer customer = new Customer();
            customer.FirstName = "Aidas";
            //customer.LastName = "Baranauskas";

            string expected = "Aidas";
            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void StaticTest()
        {

            //--Arrage
            var c1 = new Customer();
            c1.FirstName = "Aidas";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Bilbo";
            Customer.InstanceCount += 1;


            //--Act


            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {

            //--Arrage
            var Customer = new Customer();
            Customer.LastName = "Baranauskas";
            Customer.EmailAddress = "aidas@yahoo.com";

            bool expected = true;

            //--Act

            bool actual = Customer.Validate();
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInValidEmail()
        {

            //--Arrage
            var Customer = new Customer();
            Customer.LastName = "Baranauskas";
            Customer.EmailAddress = "    ";

            bool expected = false;

            //--Act
            bool actual = Customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInvalidLastName()
        {

            //--Arrage
            var Customer = new Customer();
            //Customer.LastName = "Baranauskas";
            Customer.EmailAddress = "aidas@yahoo.com";

            bool expected = false;


            //--Act
            bool actual = Customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
