using Microsoft.EntityFrameworkCore;
using Russian_Roulette.Models;
namespace Russian_Roulette.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Spieler> Spieler { get; set; }
        public DbSet<Bot> Bot { get; set; }
        public DbSet<Revolver> Revolver { get; set; }
        public DbSet<Punktezahl_SchereSteinPapier> Punktezahl_SchereSteinPapier { get; set; }
        public DbSet<SpielerWahl_SchereSteinPapier> SpielerWahl_SchereSteinPapier { get; set; }
        public DbSet<BotWahl_SchereSteinPapier> BotWahl_SchereSteinPapier { get; set; }
        
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
    }
}
