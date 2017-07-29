using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSingularity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var linkList = new List<String>()
            {
                "How to play Vangaurd",
                "Choose your Vanguard",
                "About new products",
                "Turnaments",
                "Championship resoults",
                "Current meta decks",
                "Bushiroad official page",
                "New episodes"
            };
            return View(linkList);
        }

    }
}