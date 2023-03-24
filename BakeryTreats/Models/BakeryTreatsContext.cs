using Microsoft.EntityFrameworkCore;

namespace BakeryTreats.Models
{
  public class BakeryTreatsContext : DbContext
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }

    public BakeryTreatsContext(DbContextOptions options) : base(options) { }
  }
}