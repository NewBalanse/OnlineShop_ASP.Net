using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace UI_OnlineBooks.Models
{
    public static class HtmlHelperCode
    {
        public static MvcHtmlString htmlString(PageModel model,Func<int,string> func)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= model.CountPage; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", func(i));
                tag.InnerHtml = i.ToString();
                if(i == model.numberPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}