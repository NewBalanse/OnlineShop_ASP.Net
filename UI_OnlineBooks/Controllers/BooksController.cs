using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBooks_Logic.Abstract;
using UI_OnlineBooks.Infrastructure;
using Ninject;
using UI_OnlineBooks.Models;
using OnlineBooks_Logic.Connect;
using OnlineBooks_Logic.model;

namespace UI_OnlineBooks.Controllers
{
    public class BooksController : Controller
    {
        NinjectInfrastructure infrastructure;
        IBooks BooksRepository;
        int countItem;
        public BooksController()
        {
            infrastructure = new NinjectInfrastructure(new StandardKernel());
            BooksRepository = infrastructure.GetService<IBooks>();
            countItem = 6;
            //using (BooksContext context = new BooksContext())
            //{
            //    context.Books.Add(new Books { Name = "Книга о лжы", Author = "Лжывый человек", Category = "Притчи", Price = 10 });
            //    context.Books.Add(new Books { Name = "Книга о правде", Author = "Правдивый человек", Category = "Притчи", Price = 12 });
            //    context.Books.Add(new Books { Name = "Книга о любви", Author = "Любящий человек", Category = "Притчи", Price = 12.5 });
            //    context.Books.Add(new Books { Name = "Книга о зле", Author = "Злой человек", Category = "Притчи", Price = 8.96 });
            //    context.Books.Add(new Books { Name = "Закон и порядок", Author = "Сам придумал", Category = "Роман", Price = 56 });
            //    context.Books.Add(new Books { Name = "Магия для новичков", Author = "Великий волшебник", Category = "Магия", Price = 137.76 });

            //    context.SaveChanges();
            //}
        }
        public ViewResult List(string category,int count =1)
        {
            ListBooksModel model = new ListBooksModel
            {
                Category = category,
                books = BooksRepository.GetBooks.Where(x => category == null || x.Category == category)
                .OrderBy(x => x.BookID).Skip((count) * countItem).Take(countItem),
                pageCofig = new PageModel
                {
                    CountItem = BooksRepository.GetBooks.Count(),
                    CountItemPage = countItem,
                    numberPage = category == null ? BooksRepository.GetBooks.Count() : BooksRepository.GetBooks.Where(x => x.Category == category).Count()
                }
            };
            return View(model);
        }
    }
}