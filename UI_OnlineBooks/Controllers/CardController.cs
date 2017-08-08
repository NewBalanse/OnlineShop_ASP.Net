using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBooks_Logic.model;
using OnlineBooks_Logic.Abstract;
using UI_OnlineBooks.Models;
using UI_OnlineBooks.Infrastructure;
using Ninject;

namespace UI_OnlineBooks.Controllers
{
    public class CardController : Controller
    {
        NinjectInfrastructure infrastructure;
        IBooks BooksRepository;
        List<CardList> TestListBooks;
        public CardController()
        {
            infrastructure = new NinjectInfrastructure(new StandardKernel());
            BooksRepository = infrastructure.GetService<IBooks>();
            TestListBooks = new List<CardList>();
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new ViewCard {
                cardlogic = GetCard(),
                returnUrl = returnUrl
            });

        }
        public PartialViewResult Sum(string returnUrl)
        {
            return PartialView(new ViewCard{cardlogic = GetCard(),returnUrl=returnUrl });
        }
        public RedirectToRouteResult AddToCard(string returnUrl,int booksID)
        {
            Books books = BooksRepository.GetBooks.FirstOrDefault(x => x.BookID == booksID);
            if( books != null)
            {
                GetCard().AddItem(books, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCard(int booksID,string returnUrl)
        {
            Books books = BooksRepository.GetBooks.FirstOrDefault(x => x.BookID == booksID);
            if(books != null)
            {
                GetCard().Remove(books);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public CardLogic GetCard()
        {
            CardLogic card = (CardLogic)Session["Card"];
            if(card == null)
            {
                card = new CardLogic();
                Session["Card"] = card;
            }
            return card;
        }
        public PartialViewResult EndShop()
        {
            return PartialView("EndShop");
        }

        public void ShoppindEnd(string Name, string Adress, string City, string Country, string phone)
        {
            ShopEven theEnd = new ShopEven { AllBooks = GetCard(), user = new User {Name = Name,Adress=Adress,City=City,Country=Country,Phone=phone } };
        }
    }
}