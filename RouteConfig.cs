﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WheelsWorld
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

            routes.MapRoute(
                name: "Dashboard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Dashboard", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CreateAnnounce",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "NewAnnounce", id = UrlParameter.Optional }
            );
        }
    }
}
