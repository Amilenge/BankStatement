using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AngularMVC.App_Start;

namespace FinacialStatement
{
    public class RouteConfig 
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            /*
            //routes.IgnoreRoute("views/");

            //routes.IgnoreRoute("app/");



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new
                {
                    serverRoute = new ServerRouteConstraint(url => {
                        return url.PathAndQuery.StartsWith("/api", StringComparison.InvariantCultureIgnoreCase);
                    })
                }
            );

            
            routes.MapRoute(
                name: "Angular",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Index" }
            );
            */
        }
    }
}
