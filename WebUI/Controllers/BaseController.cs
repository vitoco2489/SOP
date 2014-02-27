using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        public BaseController()
        {//
            Thread.CurrentThread.CurrentCulture=new CultureInfo("es-CL");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CL");
        }

    }
}
