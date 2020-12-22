using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class ClimateDetailContext : DbContext
    {
        public ClimateDetailContext(DbContextOptions<ClimateDetailContext> options) : base(options)
				{}

        public DbSet<ClimateDetail> ClimateDetails { get; set; }
    }
}
