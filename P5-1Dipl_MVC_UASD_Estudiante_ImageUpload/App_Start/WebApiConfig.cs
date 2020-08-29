using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace P5_1Dipl_MVC_UASD_Estudiante_ImageUpload
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
