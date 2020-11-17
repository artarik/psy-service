using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psy.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? TypeId { get; set; }
        public TimeSpan Duration { get; set; }
        public Type Type { get; set; }

    }
}