using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BestRestaurants.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace BestRestaurants.Controllers
{
  public class HomeController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public HomeController(BestRestaurantsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}