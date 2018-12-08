﻿using System;
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

        public ActionResult LastMinuteDeals()
        {
            var events = GetLastMinuteDeals();
            return PartialView("LastMinuteDeals", events);
        }

        private List<Event> GetLastMinuteDeals()
        {
            DateTime now = System.DateTime.Now;
            DateTime last = System.DateTime.Now.AddDays(2);
            List<Event> events = db.Events.Where(a => (a.StartDate > now) &&
                                                      (a.StartDate < last)).ToList();
            return events;
        }

        public ActionResult FindAnEvent()
        {
            return View();
        }

        public ActionResult _SearchEvents()
        {
            return PartialView();
        }

        public ActionResult _SearchEventsResults(string EventOrType, string Location)
        {

            if (EventOrType.Length > 0)
            {
                //search by event or event type
                var getEvents = GetEventSearch(EventOrType);
                if (getEvents.Count > 0) { return PartialView(getEvents); }
                else return PartialView("_NoResults");
            }
            else if (Location.Length > 0)
            {
                //search by location
                var getEvents = GetLocationSearch(Location);
                if (getEvents.Count > 0) { return PartialView(getEvents); }
                else return PartialView("_NoResults");
            }
            return PartialView("_NoResults");
        }


        private List<Event> GetEventSearch(string s)
        {
            return db.Events.Where(e => e.Title.Contains(s) || e.EventType.Type.Contains(s)).ToList();
        }

        private List<Event> GetLocationSearch(string s)
        {
            return db.Events.Where(e => e.State.Contains(s) || e.City.Contains(s)).ToList();
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