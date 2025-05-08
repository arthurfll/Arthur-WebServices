using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class CaixaController : Controller
  {
    private readonly AppDbContext _context;
    public CaixaController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet("Vendas")]
    public async Task<IActionResult> GetAllVendas()
    {
      var vendas = await _context.Vendas.ToListAsync();
      return Ok(vendas);
    }
    [HttpPost("Nova-Venda")]
    public async Task<IActionResult> NewVenda(Venda obj)
    {
      obj.Date = DateTime.Now;
      await _context.Vendas.AddAsync(obj);
      await _context.SaveChangesAsync();
      return Ok();
    }
  }
}

