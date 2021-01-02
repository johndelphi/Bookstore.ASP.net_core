using Bookstore.Models;
using Bookstore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
  public class BookController : Controller
  {
    private readonly BookRepository bookRepository = null;
    public BookController()
    {
      bookRepository = new BookRepository();
    }
   public List<Books> GetALLBooks()
    {
      return bookRepository.GetBooks();
    }
    
  }
}
