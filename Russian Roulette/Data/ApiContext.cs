using Microsoft.EntityFrameworkCore;
using Russian_Roulette.Models;
namespace Russian_Roulette.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Spieler> Spieler { get; set; }
        public DbSet<Bot> Bot { get; set; }
        public DbSet<Revolver> Revolver { get; set; }
        
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
    }
}
