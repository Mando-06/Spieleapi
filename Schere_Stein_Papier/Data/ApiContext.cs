using System.Collections.Generic;
using System.Data.Entity;
using Schere_Stein_Papier.Models;

namespace Schere_Stein_Papier.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<SpielAPI> Spiele { get; set; }
        public object Spiel { get; set; }

        public DbSet<Spieler> Spieler { get; set; }
        public DbSet<Bot> Bot { get; set; }


    }
}
