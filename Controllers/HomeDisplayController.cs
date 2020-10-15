using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kiwi.Controllers
{
    public class HomeDisplayController : Controller
    {
        // GET: HomeDisplay
        public ActionResult Index()
        {
            return View();
        }
    }
}