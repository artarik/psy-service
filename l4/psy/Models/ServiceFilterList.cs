using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace psy.Models
{
    public class ServiceFilterList
    {
        public IEnumerable<Service> Services { get; set; }
        public SelectList Types { get; set; }
    }
}