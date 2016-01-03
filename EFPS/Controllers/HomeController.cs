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
            return View();
        }
        public JsonResult ExampleTable() {
            EFPSEntities entities = new EFPSEntities();
            IList<PII> people = (from FirstName in entities.PIIs select FirstName).ToList();
            var jsondata = new
            {
                rows = new object[people.Count()]
            };
            int i=0;
            foreach (var p in people)
            {
                jsondata.rows[i++] = new
                {
                    cell = new object[]{
                        p.FirstName,
                        p.LastName
                    }
                };
            }
            return Json(jsondata,JsonRequestBehavior.AllowGet);
        }

    }
}
