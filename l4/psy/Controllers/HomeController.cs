using psy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity;
using Type = psy.Models.Type;

namespace psy.Controllers
{
    public class HomeController : Controller
    {

        ServiceContext db = new ServiceContext();
        public ActionResult Index()
        {
            var services = db.Services.Include(s => s.Type);

            return View(services.ToList());

        }

        public ActionResult FirstService()
        {
            var firstservice = db.Services.FirstOrDefault();
            return View(firstservice);
        }

        public ActionResult PageView(int page = 1)
        {

            var services = db.Services.Include(s => s.Type).ToList();
            int pageSize = 8;
            IEnumerable<Service> servicesOnPage = services.Skip((page - 1) * pageSize).Take(pageSize);
            PagePag pagePag = new PagePag { PageNumber = page, PageSize = pageSize, TotalServices = services.Count};
            ViewServices viewservices = new ViewServices { Services = servicesOnPage, PagePag = pagePag };
            return View(viewservices);
        }

        public ActionResult FilterView(int? type)
        {
            var services = db.Services.Include(s => s.Type);
            if (type != null && type != 0)
            {
                services = services.Where(s => s.TypeId == type);
            }
            List<Type> types = db.Types.ToList();
            types.Insert(0, new Type { TypeName = "Все типы", Id = 0 });
            ServiceFilterList serviceFilterList = new ServiceFilterList
            {
                Services = services.ToList(),
                Types = new SelectList(types, "Id", "TypeName")
            };
            return View(serviceFilterList);
        }




        [HttpGet]
        public ActionResult Create()
        {
            SelectList types = new SelectList(db.Types, "Id", "TypeName");
            ViewBag.Types = types;
            
            return View(); 

        }

        [HttpPost]
        public ActionResult Create(Service service)
        {
            db.Services.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) 
            {
                return HttpNotFound();    
            }
            Service service = db.Services.Find(id);
            if (service != null) 
            {
                SelectList types = new SelectList(db.Types, "Id", "TypeName", service.TypeId);
                ViewBag.Types = types;
                return View(service);

            }

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Edit(Service service)
        {
            db.Entry(service).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Service service = db.Services.Find(id);
            if (service != null)
            {
                SelectList types = new SelectList(db.Types, "Id", "TypeName", service.TypeId);
                ViewBag.Types = types;
                return View(service);

            }

            return RedirectToAction("Index");

        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Service service = db.Services.Find(id);
            if (service != null)
            {
                db.Services.Remove(service);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}