using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Entities;

namespace Portfolio.Api
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Case> Cases { get; set; }
        
        public DbSet<Image> Images { get; set; }
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}
    }
}