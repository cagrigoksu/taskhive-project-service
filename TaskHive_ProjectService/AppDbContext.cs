using Microsoft.EntityFrameworkCore;
using TaskHive_ProjectService.Models.Data;

namespace TaskHive_ProjectService
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProjectDataModel> Projects { get; set; }

    }
}
