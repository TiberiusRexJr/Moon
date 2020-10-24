using Moon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Moon.Controllers
{
    public class HomeController : Controller
    {
        MoonEntities db = new MoonEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
        public ActionResult GetData()
        {
            List<MCRN> data=            db.MCRNs.ToList<MCRN>();
            return Json(new { data = data }, JsonRequestBehavior.AllowGet); ;
        }
        [HttpPost]
        public JsonResult PostData(MCRN record)
        {
            if(ModelState.IsValid)
            {
                db.MCRNs.Add(record);
                db.SaveChanges();
            }
            return Json(record, JsonRequestBehavior.AllowGet);
        }
        
        public bool DeleteData(MCRN record)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                db.MCRNs.Remove(record);
                db.SaveChanges();
                status = true;
            }
            return status;
        }
    }
}