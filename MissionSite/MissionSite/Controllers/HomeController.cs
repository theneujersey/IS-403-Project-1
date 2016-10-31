﻿using System;
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
            mission.Add(new SelectListItem { Text = "Korea, Busan Mission", Value = "0" });
            mission.Add(new SelectListItem { Text = "Brazil, Rio De Janeiro Mission", Value = "1" });
            mission.Add(new SelectListItem { Text = "Czech/Slovak Mission", Value = "2"});
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

        public ViewResult missionFAQs(string Mission)
        {
            if (Mission.Equals("0"))
            {
                ViewBag.messageString = "Korea, Busan Mission";
                ViewBag.president = "Kenneth S. Barrow";
                ViewBag.address1 = "Korea Busan Mission";
                ViewBag.address2 = "Dongnae PO Box 73";
                ViewBag.address3 = "Busan-si";
                ViewBag.address4 = "Busan-gwangyeoksi 607-600";
                ViewBag.address5 = "SOUTH KOREA";
                ViewBag.language = "Korean";
                ViewBag.climate = "Moderate";
                ViewBag.religion = "Korean Buddhism";
                ViewBag.flag = "korea.gif";
            }

            else if (Mission.Equals("1"))
            {
                ViewBag.messageString = "Brazil, Rio De Janeiro Mission";
                ViewBag.president = "Geraldo Lima";
                ViewBag.address1 = "Brazil Rio De Janeiro Mission";
                ViewBag.address2 = "Rua Dois de Dezembro 78 salas 703/704";
                ViewBag.address3 = "Flamengo";
                ViewBag.address4 = "22220-040 Rio de Janeiro-RJ";
                ViewBag.address5 = "Brazil";
                ViewBag.language = "Portuguese";
                ViewBag.climate = "Hot and humid";
                ViewBag.religion = "Roman Catholicism";
                ViewBag.flag = "brazil.png";
            }
            else if (Mission.Equals("2"))
            {
                ViewBag.messageString = "Czech/Slovak Mission";
                ViewBag.president = "Jan Pohořelický";
                ViewBag.address1 = "Czech/Slovak Mission";
                ViewBag.address2 = "Badeniho 1";
                ViewBag.address3 = "160 00 Praha 6";
                ViewBag.address4 = "Czech Republic";
                ViewBag.language = "Czech and Slovak";
                ViewBag.climate = "Like Utah";
                ViewBag.religion = "Roman Catholicism";
                ViewBag.flag = "czech-slovak.jpg";
            }

                
            else
                ViewBag.messageString = "Other";

           

            return View();
        }

        public ViewResult Questions(string Question)
        {
            ViewBag.userQuestion = Question;
            return View("missionFAQs");
        }
    }
}