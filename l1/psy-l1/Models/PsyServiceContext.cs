using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace psy_l1.Models
{
    public class PsyServiceContext : DbContext
    {
        public DbSet<PsyService> PsyServices { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}