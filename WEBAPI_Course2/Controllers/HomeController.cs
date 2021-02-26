using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBAPI_Course2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult GetBooks()
        {


            return new JsonResult { Data = "Test", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}
