using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universidade.Contoso.Web.Controllers
{
    public class HomeController : Controller
    {
        string tema = "_Cyborg";

        public ActionResult Index()
        {

            if (!ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("UniversidadeContosoTema"))
            {
                HttpCookie cookie = new HttpCookie("UniversidadeContosoTema", tema);
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
            }
            else
            {
                HttpCookie cookie = HttpContext.Request.Cookies.Get("UniversidadeContosoTema");

                tema = cookie.Value;
            }

            ViewBag.tema = tema;
            ViewBag.Title = "Universidade";
            
            return View();
        }
    }
}