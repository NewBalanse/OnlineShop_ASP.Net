using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI_OnlineBooks
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,"",
                new
                {
                    controller = "Books",
                    action = "List",
                    category = (string)null,
                    page =1 
                }
                );
            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new {controller = "Books",action = "List",category = (string)null},
                constraints: new {page = @"/id+"}
                );
            routes.MapRoute(null,"category",new {controller = "Books",action="List",page =1 });
            routes.MapRoute(null,"{category}/Page{page}",new { controller = "Books" , action = "List" },new {page = @"/id+"});
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
