using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Russian_Roulette.Models;
using Russian_Roulette.Data;

namespace Russian_Roulette.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RussianRouletteController : ControllerBase
    {
        private readonly ApiContext _context;

        public RussianRouletteController(ApiContext context)
        {
            _context = context;
        }

        //create a new player
        [HttpPost]  
        public ActionResult<Spieler> CreatePlayer()
        {
            Spieler spieler = new Spieler();

            Random rnd = new Random();
            spieler.loadedChamber = rnd.Next(1, 7);
            spieler.shotChamber = rnd.Next(1, 7);
            spieler.istSpielerAmZug = true; // Der menschliche Spieler beginnt

            _context.Spieler.Add(spieler);
            _context.SaveChanges();

            return spieler;
        }

        //update the player
        [HttpPut("{id}")]
        public ActionResult<Spieler> UpdatePlayer(int id)
        {
            Spieler spieler = _context.Spieler.Find(id);

            if (spieler == null)
            {
                return NotFound();
            }

            if (spieler.Leben <= 0)
            {
                spieler.AmLeben = false;
            }
            else
            {
                if (spieler.istSpielerAmZug)
                {
                    // Der menschliche Spieler ist am Zug
                    if (spieler.shotChamber == spieler.loadedChamber)
                    {
                        spieler.Leben--;
                    }

                    spieler.shotChamber++;

                    if (spieler.shotChamber > 6)
                    {
                        spieler.shotChamber = 1;
                    }

                    spieler.AmLeben = spieler.Leben > 0;
                }
                else
                {
                    // Der Computergegner ist am Zug
                    // Implementieren Sie hier die Logik für den Computergegner
                }

                // Wechseln Sie den Spieler
                spieler.istSpielerAmZug = !spieler.istSpielerAmZug;
            }

            _context.SaveChanges();
            return spieler;
        }
    }
}