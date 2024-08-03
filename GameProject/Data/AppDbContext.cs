using GameProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GameProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Game> Games{ get; set; }
    }
}
