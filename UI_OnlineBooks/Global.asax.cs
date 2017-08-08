using OnlineBooks_Logic.Connect;
using OnlineBooks_Logic.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Data.Entity;

namespace UI_OnlineBooks
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<BooksContext>(new DropCreateDatabaseIfModelChanges<BooksContext>());
        }
    }
}
