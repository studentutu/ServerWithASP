﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SetupMVC.Controllers
{
    public class HomeController : Controller
    {
        public const bool Home = false;
        /// <summary>
        ///  
        /// </summary>
        /// <returns> View with the name - Index !</returns>
        public ActionResult Index()
        {
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