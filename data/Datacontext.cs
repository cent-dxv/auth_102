using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace auth_102.data;

public class DataContext : IdentityDbContext


{




  public DataContext(DbContextOptions<DataContext> options) : base(options)
  {
  }

  // public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}
