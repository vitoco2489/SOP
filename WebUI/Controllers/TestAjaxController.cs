using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models.test;

namespace WebUI.Controllers
{
    public class TestAjaxController : Controller
    {
        //
        // GET: /TestAjax/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult TestFromJqueryJson()
        {
            prueba a = new prueba() { Id = 1, Nombre = "John", Apellido = "Munoz" };
            return Json(a);
        }
        [HttpPost]
        public JsonResult TestListJsonFromJqueryJson()
        {
            List<prueba> jlist=new List<prueba>();
            return Json(new List<prueba>(){new prueba(){Id = 1, Nombre = "John", Apellido = "Munoz"},new prueba(){Id = 2, Nombre = "Juan", Apellido = "Catalan"}});
        }

    }
}
