using System.Web.Http;

namespace MyToDoAPI
{
    public static class WebApiConfig
    {
        public static void Register(System.Web.Http.HttpConfiguration config)
        {

            // Web API configuration and services
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
