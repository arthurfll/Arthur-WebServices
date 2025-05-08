using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data 
{
  public class AppDbContext: DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Venda> Vendas { get;set; }
  }
}


