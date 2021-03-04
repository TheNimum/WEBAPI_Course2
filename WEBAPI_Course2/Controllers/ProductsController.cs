using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WEBAPI_Course2.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;


namespace WEBAPI_Course2.Controllers
{



    public class ProductsController : Controller
    {
        public List<Books> book = new List<Books>();

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
        [HttpGet]
        public ActionResult GetAllBooksInfo()
        {
            List<Books> BInfo = new List<Books>
            {
                new Books() { ID = 1001, BookAuthor = "jesus", Titel = "Bibel", BookInfo = "Tråkig bok" },
                new Books() { ID = 1002, BookAuthor = "James white", Titel = "Fotball", BookInfo = "bra book" },
                new Books() { ID = 1003, BookAuthor = "Mark J Price ", Titel = "c# något", BookInfo = "skolbok" },
                new Books() { ID = 1004, BookAuthor = "Bonkers ", Titel = "barnboken", BookInfo = "lalal" }
            };
            return new JsonResult { Data = BInfo, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        
        [HttpPost]
        public ActionResult AddBook(Books book)
        {
            List<Books> add_book = new List<Books>();
            add_book.Add(book);



            return new HttpStatusCodeResult(200);
        }
    }
}