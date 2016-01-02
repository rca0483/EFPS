using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFPS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Models.People person = new Models.People();

            Models.EFPSEntities entities = new Models.EFPSEntities();

            Models.PII result = entities.PIIs.FirstOrDefault();  
            person.LastName = result.LastName;
            person.FirstName = result.FirstName;        
            return View(person);
        }

    }
}
