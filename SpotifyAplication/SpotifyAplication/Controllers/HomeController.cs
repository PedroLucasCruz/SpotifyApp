using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpotifyAplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            ViewBag.Title = "Home Page";            
            return View();
        }

        public ActionResult sessao1()
        {
            return RedirectToAction("Profile");
        }

    }
}
