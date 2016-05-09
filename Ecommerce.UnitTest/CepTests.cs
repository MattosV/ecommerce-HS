using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecommerce.Utils;

namespace Ecommerce.UnitTest
{
    [TestClass]
    public class CepTests
    {
        [TestMethod]
        public void IfCepIsNull()
        {
            var result = Validation.CheckCEP(null);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IfCepIsEmpty()
        {
            var result = Validation.CheckCEP(string.Empty);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IfCepIsWhiteSpaces()
        {
            var result = Validation.CheckCEP(" ");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IfCepIsValid()
        {
            var result = Validation.CheckCEP("13044000");
            Assert.AreEqual("Brasil", result.Country);
            Assert.AreEqual("Campinas", result.City);
            Assert.AreEqual("Jardim dos Oliveiras", result.Neighborhood);
            Assert.AreEqual("Rua Agnaldo Macedo", result.Street);
            Assert.AreEqual("13044000", result.Zip);
        }

        [TestMethod]
        public void IfCepIsInvalid()
        {
            var result = Validation.CheckCEP("1304445");
            Assert.AreEqual("Brasil", result.Country);
            Assert.AreEqual("Não encontrado", result.City);
            Assert.AreEqual(null, result.Neighborhood);
            Assert.AreEqual("Não encontrado", result.Street);
            Assert.AreEqual(null, result.Zip);
        }
    }
}