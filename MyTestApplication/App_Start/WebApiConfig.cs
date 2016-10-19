using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyTestApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //To Prevent error in fetching data from relational tables
            var json = config.Formatters.JsonFormatter;
            //***It Was Important To be None otherwise I got unexpected result in browser****
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;//returns 500 error if "None", returns unwanted data and format if "Objects"
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
