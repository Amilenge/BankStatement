using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FinacialStatement.Filters;

namespace FinacialStatement
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

            /*
             *      Custom global filters
             */

            // Apply exception filters
            config.Filters.Add(new ExceptionFilter());

            // enable cors for Angular client site
            config.Filters.Add(new HttpAllowCors());
        }
    }
}
