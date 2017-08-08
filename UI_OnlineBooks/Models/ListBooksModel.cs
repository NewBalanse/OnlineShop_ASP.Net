using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineBooks_Logic.model;

namespace UI_OnlineBooks.Models
{
    public class ListBooksModel
    {
        public IEnumerable<Books> books { get; set; }
        public PageModel pageCofig { get; set; }
        public string Category { get; set; }
    }
}