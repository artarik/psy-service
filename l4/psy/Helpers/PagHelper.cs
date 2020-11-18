using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using psy.Models;
using System.Web.Mvc;
using System.Text;

namespace psy.Helpers
{
    public static class PagHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagePag pagePag, Func<int, string> pageUrl)
        {
            StringBuilder res = new StringBuilder();
            for (int s = 1; s <= pagePag.TotalPages; s++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(s));
                tag.InnerHtml = s.ToString();
                if (s == pagePag.PageNumber)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                res.Append(tag.ToString());
            }
            return MvcHtmlString.Create(res.ToString());
        }
    }
}