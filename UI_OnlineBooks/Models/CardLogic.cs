using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineBooks_Logic.model;

namespace UI_OnlineBooks.Models
{
    public class CardLogic
    {
        List<CardList> listCard = new List<CardList>();

        public void AddItem(Books books, int Count)
        {
            CardList card = listCard.Where(x => x.order.BookID == books.BookID).FirstOrDefault();
            if (card == null)
            {
                listCard.Add(new CardList
                {
                    order = books,
                    COunt = Count
                });
            }
            else
                card.COunt += Count;
        }
        public void Remove(Books books)
        {
            listCard.RemoveAll(x => x.order.BookID == books.BookID);
        }
        public double TotalPrice()
        {
            return listCard.Sum(e => e.order.Price * e.COunt);
        }
        public void ClearAll()
        {
            listCard.Clear();
        }

        public IEnumerable<CardList> list
        {
            get { return listCard; }
        }

    }

    public class CardList
    {
        public Books order { get; set; }
        public int COunt { get; set; }
    }
}