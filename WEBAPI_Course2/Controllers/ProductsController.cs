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
        public ActionResult GetBookByID(int id)

        {
            List<Books> binfo = new List<Books>
            {
                new Books() { ID = 1001, BookAuthor = "jesus", Titel = "Bibel", BookInfo = "Tråkig bok" },
                new Books() { ID = 1002, BookAuthor = "James white", Titel = "Fotball", BookInfo = "bra book" },
                new Books() { ID = 1003, BookAuthor = "Mark J Price ", Titel = "c# något", BookInfo = "skolbok" },
                new Books() { ID = 1004, BookAuthor = "Bonkers ", Titel = "barnboken", BookInfo = "lalal" }
            };
            
            var selectedbook = binfo.Where(o => o.ID == id).FirstOrDefault();
            if (selectedbook == null)
                return new HttpStatusCodeResult(204);
        
            return new JsonResult { Data = selectedbook, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
    }
}