using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FactorialProject;

namespace FactorialTest
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void TestCurrencyConverter()
        {
            Mock<RateRetriever> r = new Mock<RateRetriever>();

            r.Setup(x => x.GetCurrentRateFromYahooFinance("USD", "SGD")).Returns(1.4);

            CurrencyConverter c = new CurrencyConverter(r.Object);

            double result = c.Convert("USD", "SGD", 100);

            Assert.AreEqual(140,result);
        }
    }
}
