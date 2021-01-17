using Microsoft.EntityFrameworkCore;

namespace API.Models
{
  public class ClimateDetailContext : DbContext
  {
    public ClimateDetailContext(DbContextOptions<ClimateDetailContext> options) : base(options)
    { }

    public DbSet<ClimateDetail> ClimateDetails { get; set; }
  }
}