using Autofac;
using Autofac.Integration.Mvc;
using Core.Data;
using Core.Data.Models;
using Core.Services;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region Dependency Injection

            var builder = new ContainerBuilder();

            // Register mvc controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register Business Logic
            builder.RegisterType<ExampleBL>().As<IBusinessLogic<Example>>().InstancePerRequest();

            // Register services
            builder.RegisterType<ExampleService>().As<IExampleService>().InstancePerRequest();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            #endregion
        }
    }
}
