using GestionSilabos.Helpers;
using GestionSilabos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionSilabos.Controllers
{
    public class SilabosController : Controller
    {
        SilaboDBHandler handler = new SilaboDBHandler();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ListarSilabos()
        {
            List<SilaboHelper> silabos = handler.ListarSilabos();
            return Json(new { data = silabos });
        }

    }
}