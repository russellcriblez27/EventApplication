using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly EventDb db = new EventDb();

        public ActionResult Index()
        {
            return View();
        }

        private ActionResult LastMinuteDeals()
        {
            var events = GetLastMinuteDeals();
            return PartialView("LastMinuteDeals", events);
        }

        private List<Event> GetLastMinuteDeals()
        {
            List<Event> events = db.Events.Where(a => a.StartDate.Date == System.DateTime.Now.Date ||
                                                      a.StartDate.Date == System.DateTime.Now.Date.AddDays(1) ||
                                                      a.StartDate.Date == System.DateTime.Now.Date.AddDays(2)).ToList();
            return events;
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