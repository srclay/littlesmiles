﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LittleSmiles.Models;

namespace LittleSmiles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Qualifications()
        {
            return View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Testimonials()
        {
            return View();
            //return View(db.Testimonials.ToList());
        }
        [HttpGet]
        public IActionResult Admin()
        {
            var a = new Admin() { Availability = "1 Full time place" };
            return View(a);
        }

        [HttpPost]
        public IActionResult Admin(Admin a)
        {
            return View(a);
        }


        public IActionResult Parents()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
