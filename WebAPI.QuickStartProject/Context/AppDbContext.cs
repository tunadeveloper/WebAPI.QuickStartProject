using Microsoft.EntityFrameworkCore;
using WebAPI.QuickStartProject.Entity;

namespace WebAPI.QuickStartProject.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
    }
}
