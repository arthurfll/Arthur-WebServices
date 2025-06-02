using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<CategoryTag> CategoryTags { get; set; }
  }
}


