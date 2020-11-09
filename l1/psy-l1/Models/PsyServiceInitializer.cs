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
            db.PsyServices.Add(new PsyService {Name = "Услуга 1 ", Type = "Взрослые", Price = 2000 });
            db.PsyServices.Add(new PsyService {Name = "Услуга 2 ", Type = "Дошкольники", Price = 1000 });
            db.PsyServices.Add(new PsyService {Name = "Услуга 3 ", Type = "Школьники", Price = 1500 });
            db.PsyServices.Add(new PsyService {Name = "Услуга 4", Type = "Бабушки и Дедушки", Price = 1200 });
            base.Seed(db);

        }
    }
}