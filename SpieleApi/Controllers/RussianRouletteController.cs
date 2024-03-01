using Microsoft.AspNetCore.Mvc;
using Russian_Roulette.Data;
using Russian_Roulette.Models;

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

        public class GameResult
        {
            public Spieler Spieler { get; set; }
            public Bot Bot { get; set; }
            public Revolver Revolver { get; set; }
        }

        [HttpPost]
        public ActionResult<GameResult> CreateGame()
        {
            Spieler spieler = new Spieler();
            Bot bot = new Bot();
            Revolver revolver = new Revolver();

            Random rnd = new Random();
            revolver.loadedChamber = rnd.Next(1, 7);
            revolver.shotChamber = rnd.Next(1, 7);

            spieler.istSpielerAmZug = true;

            _context.Spieler.Add(spieler);
            _context.Bot.Add(bot);
            _context.Revolver.Add(revolver);

            _context.SaveChanges();

            return new GameResult { Spieler = spieler, Bot = bot, Revolver = revolver };
        }

        [HttpPut("{id}")]
        public ActionResult<GameResult> UpdatePlayer(int id)
        {
            Spieler spieler = _context.Spieler.First();
            Bot bot = _context.Bot.First();
            Revolver revolver = _context.Revolver.First();

            if (spieler == null || bot == null)
            {
                return NotFound();
            }

            // Game Over
            if (spieler.Leben <= 0)
            {
                spieler.AmLeben = false;
                _context.SaveChanges();
                return Ok("You Lost");
            }
            else if (bot.Leben <= 0)
            {
                bot.AmLeben = false;
                _context.SaveChanges();
                return Ok("You Won");
            }

            // Game Logic
            else
            {
                if (spieler.istSpielerAmZug)
                {
                    if (revolver.shotChamber == revolver.loadedChamber)
                    {
                        spieler.Leben--;
                        revolver.loadedChamber = new Random().Next(1, 7); // Reload
                    }

                    revolver.shotChamber++;

                    if (revolver.shotChamber > 6)
                    {
                        revolver.shotChamber = 1;
                    }

                    spieler.AmLeben = spieler.Leben > 0;
                }
                else
                {
                    if (revolver.shotChamber == revolver.loadedChamber)
                    {
                        bot.Leben--;
                        revolver.loadedChamber = new Random().Next(1, 7); // Reload
                    }

                    revolver.shotChamber++;

                    if (revolver.shotChamber > 6)
                    {
                        revolver.shotChamber = 1;
                    }

                    bot.AmLeben = bot.Leben > 0;
                }

                spieler.istSpielerAmZug = !spieler.istSpielerAmZug;
            }

            _context.SaveChanges();
            return new GameResult { Spieler = spieler, Bot = bot, Revolver = revolver };
        }
    }
}
