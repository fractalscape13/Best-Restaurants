using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Restaurant.Models;

namespace Restaurant.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}