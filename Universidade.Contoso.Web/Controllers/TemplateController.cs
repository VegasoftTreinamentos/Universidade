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

            return View("Index");
        }

        public ActionResult Bootstrap()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_bootstrap";

            return View("Index");
        }

        public ActionResult Cosmo()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_cosmo";

            return View("Index");
        }

        public ActionResult Superhero()
        {
            ViewBag.Title = "Templates Avançado";
            ViewBag.tema = "_superhero";

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