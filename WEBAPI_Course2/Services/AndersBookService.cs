using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPI_Course2.Interface;
using WEBAPI_Course2.Classes;


namespace WEBAPI_Course2.Services
{
    public class AndersBookService : IBookService
    {
        public bool AddBook(IBook book)
        {
            return false;
        }

        public IBook GetBook(int id)
        {
            return new Book(1, "Torkel I Knipa", "någon Dansk", "komedi");
        }

        public List<IBook> GetListOfBooks()
        {
            return new List<IBook>();
        }

        public bool RemoveBook(int id)
        {
            return false;
        }
    }
}