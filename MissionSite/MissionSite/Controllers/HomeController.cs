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
            List<SelectListItem> mission = new List<SelectListItem>();
            mission.Add(new SelectListItem { Text = "Select a Mission", Value = "0" });
            mission.Add(new SelectListItem { Text = "Korea, Busan Mission", Value = "1" });
            mission.Add(new SelectListItem { Text = "Brazil, Rio De Janeiro Mission", Value = "2" });
            mission.Add(new SelectListItem { Text = "Czech/Slovak Mission", Value = "3" });
            ViewBag.Mission = mission;

            return View();
        }

        public ActionResult Contact()
        {
            List<SelectListItem> subject = new List<SelectListItem>();
            subject.Add(new SelectListItem { Text = "Korea, Busan Mission", Value = "0" });
            subject.Add(new SelectListItem { Text = "Brazil, Rio De Janeiro Mission", Value = "1" });
            subject.Add(new SelectListItem { Text = "Czech/Slovak Mission", Value = "2" });
            subject.Add(new SelectListItem { Text = "Other", Value = "3" });
            ViewBag.Subject = subject;

            return View();
        }

        public ActionResult missionFAQs()
        {
            return View();
        }
    }
}