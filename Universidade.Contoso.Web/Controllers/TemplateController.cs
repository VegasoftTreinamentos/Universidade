using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universidade.Contoso.Web.Controllers
{
    public class TemplateController : Controller
    {

        public ActionResult Index()
        {           
            ViewBag.Title = "Universidade";

            return View();
        }
      

        // GET: Template
        public ActionResult Basico()
        {
            ViewBag.Title = "Templates Básicos";

            return View();
        }

        public ActionResult Intermediario()
        {
            ViewBag.Title = "Templates Intermediário";

            return View();
        }

        public ActionResult Avancado()
        {
            ViewBag.Title = "Templates Avançado";

            return View();
        }

        public ActionResult Amelia()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_Amelia";
            HttpCookie cookie = new HttpCookie("UniversidadeContosoTema", "_Amelia");
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);

            return View("Index");
        }

        public ActionResult Bootstrap()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_layout";

            return View("Index");
        }

        public ActionResult Cosmo()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_cosmo";

            return View("Index");
        }

        public ActionResult Darkly()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_cosmo";

            return View("Index");
        }

        public ActionResult Superhero()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_Superhero";

            return View("Index");
        }

        public ActionResult Cyborg()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_Cyborg";

            return View("Index");
        }
    }
}