
using Microsoft.EntityFrameworkCore;
using ProMan_Project.Models;

namespace ProMan_Project.Data
{
    public class ProMan_ProjectDbContext:DbContext
    {
        public ProMan_ProjectDbContext(DbContextOptions<ProMan_ProjectDbContext> options):base(options)
        {
            
        }
        public DbSet<Home> Home { get; set; }
    }
}
