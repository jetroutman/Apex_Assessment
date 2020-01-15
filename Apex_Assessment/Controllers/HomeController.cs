using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apex_Assessment.Models;

namespace Apex_Assessment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetTableInfo(string bdate, string sdate)
        {
            return Json(Models.Apex.GetInfo(), JsonRequestBehavior.AllowGet);
        }
    }
}