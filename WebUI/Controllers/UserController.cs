using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        //agrega una vista parcia al view que lo ejecute
        [HttpPost]
        public ActionResult AddPart()
        {
            return PartialView("_ItemPart");
        }
    }
}
