using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_OnlineBooks.Models
{
    public class PageModel
    {
        public int CountPage { get { return (int)Math.Ceiling((double)CountItem / CountItemPage); } }

        public int CountItem { get; set; }
        public int CountItemPage { get; set; }
        public int numberPage { get; set; }

    }
}