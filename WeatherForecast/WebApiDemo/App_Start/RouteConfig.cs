using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Values", action = "Login", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "LoginSucess",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Values", action = "LoginSucess", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "SecondDefault",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Interval",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "IntervalCall", id = UrlParameter.Optional }
           );
        }
    }
}
