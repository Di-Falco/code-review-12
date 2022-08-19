using Microsoft.EntityFrameworkCore;

namespace ParksDirectory.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options)
      : base(options) { }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      
    }
  }
}