using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Documentation routes
            routes.MapRoute(
                name: "DocumentationIndex",
                url: "Documentation",
                defaults: new { controller = "Documentation", action = "Index" }
            );

            routes.MapRoute(
                name: "DocumentationAction",
                url: "Documentation/{action}",
                defaults: new { controller = "Documentation", action = "Index" }
            );

            // Default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
