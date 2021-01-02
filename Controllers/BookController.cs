﻿using Bookstore.Models;
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
   public List<Books> GetAllBooks()
    {
      return bookRepository.GetBooks();
    }
    public Books GetBooks(int id)
    {
      return bookRepository.GetBookById(id);
    }
    public List <Books> SearchBooks(string bookName,string authorName)
    {
      return bookRepository.SearchBook(bookName, authorName);
    }
    
  }
}
