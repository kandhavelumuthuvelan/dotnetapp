using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace firstapplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //        "moviebyreleasedate",
            //        "{controller}/{action}/{year}/{month}",
            //        new { controller="moviw",action="byrealeseData"}
            //    );

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
             "moviereleasebydate",
             "movie/released/{year}/{month}",
             new { controller = "movie", action = "ByreleaseDate" }
             );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }

    }
}
