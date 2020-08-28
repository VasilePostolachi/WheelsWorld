using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WheelsWorld.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult NewAnnounce()
        {
            return View();
        }
    }
}