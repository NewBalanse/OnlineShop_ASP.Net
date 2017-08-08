using Ninject;
using OnlineBooks_Logic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI_OnlineBooks.Infrastructure;

namespace UI_OnlineBooks.Controllers
{
    public class NavigationController : Controller
    {
        NinjectInfrastructure infrastructure;
        IBooks BooksRepository;
        public NavigationController()
        {
            infrastructure = new NinjectInfrastructure(new StandardKernel());
            BooksRepository = infrastructure.GetService<IBooks>();
        }

        public PartialViewResult NavigationMenu(string categorys)
        {
            ViewBag.SelectCategory = categorys;
            IEnumerable<string> category = BooksRepository.GetBooks.Select(x => x.Category).Distinct().OrderBy(x => x);
            return PartialView(category);
        }
    }
}