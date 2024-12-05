using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SEOHealthCheckAPI.Models;

namespace SEOHealthCheckAPI.Data
{
    public class SeoDbContext : DbContext
    {
        public DbSet<SeoReport> SeoReports { get; set; }
    public SeoDbContext(DbContextOptions<SeoDbContext> options) : base(options) { }
    }
}