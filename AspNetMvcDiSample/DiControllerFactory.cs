using System;
using System.Web.Mvc;
using System.Web.Routing;
using AspNetMvcDiSample.Controllers;
using AspNetMvcDiSample.Models;

namespace AspNetMvcDiSample
{
    public class DiControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof(HomeController))
            {
                return new HomeController(new CurrencyCalculator(new InMemoryExchangeRateRepository()));
            }

            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}