using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Missions()
        {
            return View();
        }

        public ActionResult Contact()
        {
            List<SelectListItem> subject = new List<SelectListItem>();
            subject.Add(new SelectListItem { Text = "Korea, Busan", Value = "0" });
            subject.Add(new SelectListItem { Text = "Brazil, Rio De Janeiro", Value = "1" });
            subject.Add(new SelectListItem { Text = "Jacob's Mission", Value = "2" });
            subject.Add(new SelectListItem { Text = "Other", Value = "3" });
            ViewBag.Subject = subject;

            return View();
        }
    }
}