using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Dynamic;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresTreatsContext _db;
    public HomeController(PierresTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      dynamic model = new ExpandoObject();
      model.Flavors = _db.Flavors.ToList();
      model.Treats = _db.Treats.ToList();
      return View(model);
    }
  }
}