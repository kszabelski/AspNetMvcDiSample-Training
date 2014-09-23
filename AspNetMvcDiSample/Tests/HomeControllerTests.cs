using System.Web.Mvc;
using AspNetMvcDiSample.Controllers;
using AspNetMvcDiSample.Models;
using Moq;
using NUnit.Framework;

namespace AspNetMvcDiSample.Tests
{
    public class HomeControllerTests
    {
        [Test]
        public void ShouldReturnValueInViewBag()
        {
            var fakeCalculator = new Mock<ICurrencyCalculator>();
            var testMoney = new Money(5.5m, "USD");
            fakeCalculator.Setup(c => c.GetValueInCurrency(It.IsAny<Money>(), It.IsAny<string>())).Returns(testMoney);
            var controller = new HomeController();

            var result = controller.Index(0.1M, "test", "test");

            Assert.AreEqual(testMoney, ((ViewResult) result).ViewBag.Result);
        }
    }
}   