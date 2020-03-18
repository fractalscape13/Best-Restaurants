using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}