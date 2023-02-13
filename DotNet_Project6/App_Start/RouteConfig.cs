using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNet_Project6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // routes.IgnoreRoute("Test");
            //routes.IgnoreRoute("Test/Index");
            // routes.IgnoreRoute("Test/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
            name: "mymovie",
            url: "movie/dateofrelese/{month}/{year}",
            defaults: new { controller = "Movie", action = "ReleseDate" },
            constraints: new {month="\\d{2}",year="\\d{4}"}
        );
           

            routes.MapRoute(
             name: "myroute",
             url: "dotnetworking",
             defaults: new { controller = "Test", action = "Index"}
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
