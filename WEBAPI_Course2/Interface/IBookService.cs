using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI_Course2.Interface
{
    public interface IBookService
    {
        bool AddBook(IBook book);
        bool RemoveBook(int id);
        IBook GetBook(int id);
        List<IBook> GetListOfBooks();

    }
}
