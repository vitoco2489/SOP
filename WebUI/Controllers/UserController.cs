using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models.test;

namespace WebUI.Controllers
{
    public class UserController : BaseController
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            if(Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        [HttpPost]
        public ActionResult Create(prueba prueba)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
        public ActionResult Edit(int id = -1)
        {
            return View(new prueba{Apellido = "espinoza",Id=1,Nombre="victor"});
        }
        
        [HttpPost]
        public ActionResult Edit(prueba prueba)
        {
            return RedirectToAction("Detalles",prueba);
        }

        public ActionResult Detalles(prueba p)
        {
            return View(p);
        }


        //agrega una vista parcia al view que lo ejecute
        [HttpPost]
        public ActionResult AddPart()
        {
            return PartialView("_ItemPart");
        }
    }
}
