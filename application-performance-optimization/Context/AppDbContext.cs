using application_performance_optimization.Entities;
using Microsoft.EntityFrameworkCore;

namespace application_performance_optimization.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        public DbSet<UserEntity>? UserEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
