using Microsoft.AspNetCore.Mvc;
using BakeryTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace BakeryTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryTreatsContext _db;

    public HomeController(BakeryTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();

      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}