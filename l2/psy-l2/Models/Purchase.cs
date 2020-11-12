using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psy_l2.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public DateTime Date { get; set; } 
        public string Description { get; set; }
        public int PsyServiceId { get; set; }
    }
}