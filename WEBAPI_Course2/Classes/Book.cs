using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPI_Course2.Interface;
namespace WEBAPI_Course2.Classes
{

    public class Book : IBook
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Book(int id, string titel, string author, string category)
        {
            this.Id = id;
            this.Titel = titel;
            this.Author = author;
            this.Category = category;
        }
    }
}
