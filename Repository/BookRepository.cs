using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Repository
{
  public class BookRepository
  {
    public List<Books> GetBooks()
    {
      return DataSource();
    }
    public Books GetBookById(int id)
    {
      return DataSource().Where(X => X.Id == id).FirstOrDefault();

    }
    public List<Books>SearchBook(string Title,string authorName)
    {

    }
    public List<Books> DataSource()
    {
      return new List<Books>()
      {
        new Books(){Id=1,Title="phyton",Author="teric"},
        new Books(){Id=2,Title="macs",Author="longhorn"}
      };
    }
  }
}
