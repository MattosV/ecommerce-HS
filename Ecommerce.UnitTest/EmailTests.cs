using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecommerce.Utils;

namespace Ecommerce.UnitTest
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void IfEmailIsNull()
        {
            var result = Validation.CheckEmail(null);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfEmailIsEmpty()
        {
            var result = Validation.CheckEmail("");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfEmailIsWhiteSpaces()
        {
            var result = Validation.CheckEmail("");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfEmailIsValid()
        {
            var result = Validation.CheckEmail("vmattos@ciandt.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IfEmailIsWithoutArroba()
        {
            var result = Validation.CheckEmail("ABCabc.com");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfEmailIsWithoutDot()
        {
            var result = Validation.CheckEmail("ABC@abccom");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfEmailContainsWhitespace()
        {
            var result = Validation.CheckEmail("AB C@abc.com");
            Assert.AreEqual(false, result);
        }

    }
}
