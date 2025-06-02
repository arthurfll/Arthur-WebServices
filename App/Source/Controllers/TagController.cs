using App.Data;
using App.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
  public class TagController : Controller
  {
    private readonly AppDbContext _db;
    public TagController(AppDbContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      List<CategoryTag> obj = _db.CategoryTags.ToList();
      return View(obj);
    }
  }
}

