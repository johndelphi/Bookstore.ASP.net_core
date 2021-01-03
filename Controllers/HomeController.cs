using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
  public class HomeController : Controller
  {
    public  ViewResult Index()
    {
     // var obj = new { id = 1, Name = "Nitish" };
      return View("TempView/sampleview.cshtml");
    }
    public ViewResult AboutUs()
    {
      return View();
    }
    public ViewResult ContactUs()
    {
      return View();
        }
  }
}