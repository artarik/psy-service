using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psy.Models
{
    public class PagePag
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalServices { get; set; }
        public int TotalPages {
            get { return (int) Math.Ceiling((double) TotalServices / PageSize);  }
            
        }
    }
    public class ViewServices
    {
        public IEnumerable<Service> Services { get; set; }
        public PagePag PagePag { get; set; }

    }
}