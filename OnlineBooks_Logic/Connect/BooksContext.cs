using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineBooks_Logic.model;


namespace OnlineBooks_Logic.Connect
{
    public class BooksContext : DbContext
    {
        public BooksContext() :base("DBConnection")
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<User> User { get; set; }
    }
}
