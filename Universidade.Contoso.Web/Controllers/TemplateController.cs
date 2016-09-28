using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universidade.Contoso.Web.Controllers
{
    public class TemplateController : Controller
    {
        private string tema = "_Amelia";

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
            tema = "_Amelia";
            GravaCookie();

            return View("Index");
        }

        private void GravaCookie()
        {
            ViewBag.tema = tema;
            HttpCookie cookie = new HttpCookie("UniversidadeContosoTema", tema);
            cookie.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(cookie);
        }

        public ActionResult Bootstrap()
        {
            ViewBag.Title = "Templates Avançado";
            tema = "_Layout";
            GravaCookie();

            return View("Index");
        }

        public ActionResult Cosmo()
        {
            ViewBag.Title = "Templates Avançado";
            tema = "_Cosmo";
            GravaCookie();

            return View("Index");
        }

        public ActionResult Darkly()
        {
            ViewBag.Title = "Templates Avançado";
            tema = "_Darkly";
            GravaCookie();

            return View("Index");
        }

        public ActionResult Superhero()
        {
            ViewBag.Title = "Templates Avançado";
            tema = "_Superhero";
            GravaCookie();
            return View("Index");
        }

        public ActionResult Cyborg()
        {
            ViewBag.Title = "Templates Avançado";
            tema = "_Cyborg";
            GravaCookie();

            return View("Index");
        }
    }
}