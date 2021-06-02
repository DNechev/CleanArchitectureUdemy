using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data.Context
{
    public class CleanArchDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public CleanArchDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
