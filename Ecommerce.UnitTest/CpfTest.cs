
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecommerce.Utils;

namespace Ecommerce.UnitTest
{
    [TestClass]
    public class CpfTest
    {
        [TestMethod]
        public void IfCpfIsNull()
        {
            var result = Validation.CheckCpf(null);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfCpfIsEmpty()
        {
            var result = Validation.CheckCpf(string.Empty);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfCpfIsWhiteSpaces()
        {
            var result = Validation.CheckCpf(" ");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfAllNumbersIsZero()
        {
            var result = Validation.CheckCpf("000.000.000-00");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfNumbersAreOneToNine()
        {
            var result = Validation.CheckCpf("123.456.789-09");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfCpfIsShorter()
        {
            var result = Validation.CheckCpf("407.207.758");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IfCpfIsValid()
        {
            var result = Validation.CheckCpf("407.207.758-50");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IfCpfIsInvalid()
        {
            var result = Validation.CheckCpf("407.207.758-00");
            Assert.AreEqual(false, result);
        }




    }
}