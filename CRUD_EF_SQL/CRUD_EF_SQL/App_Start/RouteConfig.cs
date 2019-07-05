using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CRUD_EF_SQL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Loja", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Categorias",
            //    url: "Categorias/Nova",
            //    defaults: new { controller = "Loja", action = "CategoriaNova", id = UrlParameter.Optional }
            //);
        }
    }
}
