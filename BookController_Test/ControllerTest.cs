using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using WEBAPI_Course2.Interface;
using WEBAPI_Course2.Classes;
using WEBAPI_Course2.Controllers;
using WEBAPI_Course2.Services;
using System;
using System.Collections.Generic;

namespace BookController_Test
{
    [TestClass]
   public class ControllerTest
    {

    [TestMethod]
    private static IBook BookMethod()
    {
        return new Book(1, "xx", "lol", "dd");
    }


        [TestMethod]
        public void TestGetBookByID()
        {
            var service = new Mock<IBookService>();
            service.Setup(x => x.GetBook(1)).Returns(new Book(1, "w", "w", "w"));
            var controller = new BookController(service.Object);
            var result = controller.GetBookByID(1);

        }
        [TestMethod]
        public void TestAddBookNoExceptions()
        {

            var book = BookMethod();
            var bookservice = new Mock<IBookService>();
            bookservice.Setup(x => x.AddBook(book)).Returns(true);
           var controller = new BookController(bookservice.Object);
            var result = controller.AddBookToLibrary(book);
            bookservice.Verify(o => o.AddBook(book), Times.Once);           
            var httpcoderesult = (HttpStatusCodeResult)result;
            Assert.AreEqual(httpcoderesult.StatusCode, 200);
        }
        [TestMethod]
        public void TestAddBookReturnFalse()
        {
            var book = BookMethod();
            var bookservice = new Mock<IBookService>();
            bookservice.Setup(x => x.AddBook(book)).Returns(false);
            var controller = new BookController(bookservice.Object);
            ActionResult result = controller.AddBookToLibrary(book);
            var httpcoderesult = (HttpStatusCodeResult)result;
            Assert.AreEqual(result.GetType(), typeof(HttpStatusCodeResult));
            Assert.IsFalse(false);
        }
        
        [TestMethod]
        public void GetListofAllBooksTestSoItsNotEmpty()
        {
            var ListofBooks = new List<IBook>()
            {
                new Book(1,"Bamsesbarnbook","någon","barnbok"),
                new Book(2,"bubbes","tomtom","fo"),
                new Book(3,"oxe","bullen","tintin"),
            };
            var service = new Mock<IBookService>();
            service.Setup(x => x.GetListOfBooks()).Returns(ListofBooks);
            var controller = new BookController(service.Object);
            var result = controller.GetListOfBooks();
           
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void DeleteBookByIdTest()
        {
            var service = new Mock<IBookService>();
            service.Setup(x => x.RemoveBook(1)).Returns(false);
            var controller = new BookController(service.Object);
           // service.Verify(x => x.RemoveBook(1), Times.Once);
            ActionResult result = controller.DeleteBookByID(1);
            var httpstatuscode = (HttpStatusCodeResult)result;
            Assert.IsFalse(false);
            Assert.AreEqual(result.GetType(), typeof(HttpStatusCodeResult));

        }
    }

}
