using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FizzBuzzApplication;

namespace WebUI
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
	        BuildApplication();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }

	    private void BuildApplication()
	    {
		    var builder = new ContainerBuilder();
		    builder.RegisterControllers(typeof (Global).Assembly);
			builder.RegisterType<FizzBuzzApp>().As<IApplication>();

		    builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
		    var container = builder.Build();

			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
			GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
	
	    }
    }
}