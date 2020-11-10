using psy_l1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace psy_l1.Controllers
{
    public class HomeController : Controller
    {
        PsyServiceContext db = new PsyServiceContext();
        public ActionResult Index()
        {
            IEnumerable<PsyService> services = db.PsyServices;
            ViewBag.PsyServices = services; 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Order(int id)
        {
            ViewBag.PsyServiceId = id;
            return View();
        }

        [HttpPost]
        public string Order(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Услуга заказана, спасибо " + purchase.Person + "!";
        }

        public string Exp(double x, double y = 2)
        {
            double exp = Math.Pow(x, y);
            return "<h2>" + x + " в степени " + y + " = " + exp + "</h2>";
        }
        public FileResult GetFile()
        {
            string file_path = Server.MapPath("~/files/price.xlsx");
            string file_type = "application/xlsx";
            string file_name = "price.xlsx";
            return File(file_path, file_type, file_name);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}