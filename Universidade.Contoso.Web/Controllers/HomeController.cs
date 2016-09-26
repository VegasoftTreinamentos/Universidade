using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universidade.Contoso.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.tema = "_Cyborg";            
            ViewBag.Title = "Universidade";
            
            return View();
        }
    }
}