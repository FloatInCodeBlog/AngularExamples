using System.Web.Mvc;
using System.Web.Routing;

namespace RazorViewsForAngularJS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
    name: "Views",
    url: "views/{ctrl}/{view}",
    defaults: new { controller = "Views", action = "get" });

            routes.MapRoute(
    name: "Default",
    url: "{controller}/{*parameters}",
    defaults: new { controller = "Home", action = "base", id = UrlParameter.Optional });

        }
    }
}
