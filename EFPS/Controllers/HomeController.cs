using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFPS.Models;

namespace EFPS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            EFPSEntities entities = new EFPSEntities();
            PII result = entities.PIIs.FirstOrDefault();
            return View(result);
        }

    }
}
