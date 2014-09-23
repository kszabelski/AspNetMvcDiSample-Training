using AspNetMvcDiSample.Models;
using Moq;
using NUnit.Framework;

namespace AspNetMvcDiSample.Tests
{
    public class CurrencyCalculatorTests
    {
        [Test]
        public void ShouldCalculateExchangeRate()
        {
            var exchangeRateRepositoryMock = new Mock<IExchangeRateRepository>();
            exchangeRateRepositoryMock.Setup(e => e.GetExchangeRate("PLN", "USD")).Returns(3.0m);

            // TODO: start here be implementing calculator.
            ICurrencyCalculator calc = null;

            var convertedMoney = calc.GetValueInCurrency(new Money(5, "PLN"), "USD");

            Assert.AreEqual(15, convertedMoney.Value);
            Assert.AreEqual("USD", convertedMoney.Currency);
        }
    }
}
