﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CouchSurfing.Controllers
{
    public class RoutesDemoController : Controller
    {
        // GET: RoutesDemo
        public ActionResult One()
        {
            return View();
        }

        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }

        public ActionResult Three()
        {
            return View();
        }
    }
}