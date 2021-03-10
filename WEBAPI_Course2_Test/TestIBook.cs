
using Moq;
using WEBAPI_Course2.Interface;
using WEBAPI_Course2.Services;
using WEBAPI_Course2.Controllers;
using WEBAPI_Course2.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WEBAPI_Course2_Test
{
    [TestClass]
    public class BookControllerTest
    {
        
        //[SetUp]
        //public void SetUp()
        //{
   
        //}  
        [TestMethod]
        public void GetBookByID(int id)
        {
            Mock<IBookService> service = new Mock<IBookService>();
            id = 1;
            service.Setup(x => x.GetBook(id)).Returns(new Book(1, "test", "test", "test"));
            
            var servicecontroller = new BookController(service.Object);
            var result = servicecontroller.GetBookByID(1);

            

        }
    }
}