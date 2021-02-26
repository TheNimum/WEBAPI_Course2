using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using WEBAPI_Course2.Models;

namespace WEBAPI_Course2.Controllers
{



    public class ProductsController : Controller
    {
        [HttpGet]
        public ActionResult GetBooks()

        {
            /* List<Books> binfo = new List<Books>();
              binfo.Add(new Books() { ID = 1001, BookAuthor = "jesus", Titel = "Bibel", BookInfo = "Tråkig bok" });
              binfo.Add(new Books() { ID = 1002, BookAuthor = "James white", Titel = "Fotball", BookInfo = "bra book" });
              binfo.Add(new Books() { ID = 1003, BookAuthor = "Mark J Price ", Titel = "c# något", BookInfo = "skolbok" });*/

            //return new JsonResult {​​ Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet }​​;
            return new JsonResult {​​​​ Data = null, JsonRequestBehavior = JsonRequestBehavior.AllowGet }​​​​;

        }
    }
}
