using System.Net.Http.Headers;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common;
using Owin;
using WebApiContrib.IoC.Ninject;

[assembly: OwinStartup(typeof(SampleWebApi.Startup))]

namespace SampleWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration
            {
                DependencyResolver = new NinjectResolver(CreateKernel())
            };

            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

           // kernel.Bind<IService>().ToConstant(new Service());

            return kernel;
        }
    }
}
