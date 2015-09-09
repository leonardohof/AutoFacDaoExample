using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Core.Data;
using Core.Data.Models;
using Core.Services;
using Autofac;
using Autofac.Integration.Web;

namespace WebApplication2
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;
        public IContainerProvider ContainerProvider
        {
            get
            {
                return _containerProvider;
            }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region Dependency Injection

            var builder = new ContainerBuilder();

            // Register Business Logic
            builder.RegisterType<ExampleBL>().As<IBusinessLogic<Example>>().InstancePerRequest();

            // Register services
            builder.RegisterType<ExampleService>().As<IExampleService>().InstancePerRequest();

            var container = builder.Build();

            // Web Forms DI
            _containerProvider = new ContainerProvider(container);

            #endregion
        }
    }
}