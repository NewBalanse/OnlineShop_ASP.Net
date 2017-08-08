using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBooks_Logic.Abstract;
using OnlineBooks_Logic.model;

namespace OnlineBooks_Logic.Connect
{
    public class DBBooksRepository : IBooks
    {
        BooksContext context = new BooksContext();
        public IEnumerable<Books> GetBooks
        {
            get
            {
                return context.Books;
            }
        }
    }
}
