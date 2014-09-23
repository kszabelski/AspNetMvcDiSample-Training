using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI;
using AspNetMvcDiSample.Controllers;
using AspNetMvcDiSample.Models;
using Autofac;
using Autofac.Integration.Mvc;

namespace AspNetMvcDiSample
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ConfigureDependencyInjectionContainer();
       
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void ConfigureDependencyInjectionContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<InMemoryExchangeRateRepository>().As<IExchangeRateRepository>();
            containerBuilder.RegisterType<CurrencyCalculator>().As<ICurrencyCalculator>();
            containerBuilder.RegisterAssemblyTypes(typeof(HomeController).Assembly)
                .Where(t => t.Name.EndsWith("Controller"));

            var container = containerBuilder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}