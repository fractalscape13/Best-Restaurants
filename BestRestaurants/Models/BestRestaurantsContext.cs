using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}