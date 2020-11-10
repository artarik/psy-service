using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace psy_l1.Models
{
    public class PsyServiceInitializer : DropCreateDatabaseAlways<PsyServiceContext>
    {
        protected override void Seed(PsyServiceContext db)
        {
            db.PsyServices.Add(new PsyService {Name = "Консультация Online", Type = "Взрослые", Price = 1500 });
            db.PsyServices.Add(new PsyService {Name = "Завтрак с психологом", Type = "Взрослые", Price = 1000 });
            db.PsyServices.Add(new PsyService {Name = "Консультативная встреча", Type = "Взрослые", Price = 2000 });
            db.PsyServices.Add(new PsyService {Name = "Игра МАК", Type = "Взрослые", Price = 2000 });
            base.Seed(db);

        }
    }
}