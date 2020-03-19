using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BestRestaurants.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string UserName { get; set; }
    public string ReviewBody { get; set; }
    public int Rating { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}