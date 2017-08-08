using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBooks_Logic.Abstract;
using OnlineBooks_Logic.model;
using OnlineBooks_Logic.Connect;
using Moq;

namespace UI_OnlineBooks.Infrastructure
{
    public class NinjectInfrastructure : IDependencyResolver
    {
        private IKernel Kernel;

        public NinjectInfrastructure(IKernel param)
        {
            Kernel = param;
            AddBindings();
        }

        private void AddBindings()
        {
            Kernel.Bind<IBooks>().To<DBBooksRepository>();
        }

        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }
    }
}