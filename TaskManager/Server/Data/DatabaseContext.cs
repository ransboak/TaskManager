using Microsoft.EntityFrameworkCore;
using TaskManager.Shared.Models;

namespace TaskManager.Server.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
                
        }
        
        public DbSet<Activity> Activities { get; set; }
    }
}
