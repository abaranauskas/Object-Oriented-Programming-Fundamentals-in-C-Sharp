using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace acme.Common.Test
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            string source = "   SonicScrewdriver";
            string expected = "Sonic Screwdriver";

            Assert.AreEqual(expected, StringHandler.InsertSpaces(source));
        }
        
        [TestMethod]
        public void InsertSpacesTestWithExistigSpace()
        {
            string source = "Sonic  Screwdriver";
            string expected = "Sonic Screwdriver";

            Assert.AreEqual(expected, source.InsertSpaces());
        }
    }
}
