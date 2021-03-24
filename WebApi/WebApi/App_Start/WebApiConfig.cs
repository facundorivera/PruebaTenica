using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Cors;
using System.Web.Http;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute("*", "Content-Type, Accept, Authorization", "GET,POST,PUT,DELETE,OPTIONS")
            {
                SupportsCredentials = true
            };
            config.EnableCors(cors);


            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
