using psy_l1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}