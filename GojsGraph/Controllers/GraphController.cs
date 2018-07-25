using GojsGraph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GojsGraph.Controllers
{
    public class GraphController : Controller
    {
        //
        // GET: /Graph/
        private readonly Gestor _gestor = new Gestor();

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult ObtenerNodos()
        {
            var list = _gestor.Consultar();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult ObtenerVertices()
        {
            var list = _gestor.ConsultarVertices();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
