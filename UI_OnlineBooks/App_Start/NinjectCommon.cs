using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI_OnlineBooks.Infrastructure;

namespace UI_OnlineBooks.App_Start
{
    public class NinjectCommon
    {
        private static void RegistrationServise(IKernel kernel)
        {
            DependencyResolver.SetResolver(new NinjectInfrastructure(kernel));
        }
    }
}