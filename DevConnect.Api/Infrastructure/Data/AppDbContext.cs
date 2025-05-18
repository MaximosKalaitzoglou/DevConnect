using DevConnect.Api.DevConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Api.DevConnect.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
    }
}