using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universidade.Contoso.Web.Controllers
{
    public class TemplateController : Controller
    {
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
    }
}