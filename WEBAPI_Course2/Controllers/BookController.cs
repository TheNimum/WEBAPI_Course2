using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBAPI_Course2.Interface;
using WEBAPI_Course2.Services;
using WEBAPI_Course2.Classes;

namespace WEBAPI_Course2.Controllers
{
    public class BookController : Controller
    {
        public readonly IBookService bookservice;
        public BookController(IBookService service)
        {
            this.bookservice = service;
        }

        [HttpGet]
        public ActionResult GetBookByID(int id)
        {

            return new JsonResult { Data = bookservice.GetBook(id), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpGet]
        public ActionResult GetListOfBooks()
        {
            //var result = bookservice.GetListOfBooks();
            //if (result == null)
            //    return new HttpStatusCodeResult(500);

            return new JsonResult { Data = bookservice.GetListOfBooks(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpPost]
        public ActionResult AddBookToLibrary(IBook book)
        {
            var result = bookservice.AddBook(book);
            if (result == false)
                return new HttpStatusCodeResult(500);

            return new HttpStatusCodeResult(200);
        }
        [HttpDelete]
        public ActionResult DeleteBookByID(int id)
        {
            var result = bookservice.RemoveBook(id);
            if (result == false)
            return new HttpStatusCodeResult(500);

            return new HttpStatusCodeResult(200);
        }
    }
}