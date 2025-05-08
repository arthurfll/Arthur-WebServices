using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class PizzaController : Controller
  {
    private readonly AppDbContext _context;
    public PizzaController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet("Menu")]
    public IActionResult GetAllPizzas()
    {
      var pizzas = _context.Pizzas.ToListAsync();
      return Ok(pizzas);

    }
    [HttpPost("New")]
    public async Task<IActionResult> NewPizza(Pizza obj)
    {
      await _context.Pizzas.AddAsync(obj);
      await _context.SaveChangesAsync();

      return Ok();
    }
  }
}

