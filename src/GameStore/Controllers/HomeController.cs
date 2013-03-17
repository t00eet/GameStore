using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Find a game.  Buy a game.  Play a game.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Indie Game Store is dedicated to pretending to provide quality service for all customers.  We appreciate your interest!";

            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you got a problem, yo I'll solve it.";

            return View();
        }
    }
}
