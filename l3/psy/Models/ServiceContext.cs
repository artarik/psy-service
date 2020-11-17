using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace psy.Models
{
    public class ServiceContext : DbContext
    {
        public DbSet<Type> Types { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}