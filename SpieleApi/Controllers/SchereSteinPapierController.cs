using Microsoft.AspNetCore.Mvc;
using Russian_Roulette.Data;
using Russian_Roulette.Models;

namespace SchereSteinPapier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchereSteinPapierController : ControllerBase
    {
        private readonly ApiContext _context;

        public SchereSteinPapierController(ApiContext context)
        {
            _context = context;
        }

        public class GameResult_SchereSteinPapier
        {
            public SpielerWahl_SchereSteinPapier SpielerWahl { get; set; }
            public BotWahl_SchereSteinPapier BotWahl { get; set; }
            public Punktezahl_SchereSteinPapier Punktezahl { get; set; }
        }

        [HttpPost]
        public ActionResult<GameResult_SchereSteinPapier> StarteNeuesSpiel(SpielerWahl_SchereSteinPapier spielerWahl)
        {
            // Überprüfen, ob ein Spieler mit der gleichen ID bereits existiert
            var existierenderSpieler = _context.SpielerWahl_SchereSteinPapier.Find(spielerWahl.Id);
            if (existierenderSpieler != null)
            {
                return BadRequest("Ein Spieler mit dieser ID existiert bereits.");
            }

            BotWahl_SchereSteinPapier botWahl = new BotWahl_SchereSteinPapier();
            Punktezahl_SchereSteinPapier punktezahl = new Punktezahl_SchereSteinPapier();

            _context.SpielerWahl_SchereSteinPapier.Add(spielerWahl);
            _context.BotWahl_SchereSteinPapier.Add(botWahl);
            _context.Punktezahl_SchereSteinPapier.Add(punktezahl);

            _context.SaveChanges();

            // Gebe das neue Spiel zurück
            return new GameResult_SchereSteinPapier {SpielerWahl = spielerWahl, BotWahl = botWahl, Punktezahl = punktezahl };
        }

        [HttpPut]
        public ActionResult<GameResult_SchereSteinPapier> SpieleSchereSteinPapier()
        {
            // Bot wählt zufälliges Symbol
            BotWahl_SchereSteinPapier botWahl = new BotWahl_SchereSteinPapier();
            var random = new Random();
            int botWahlZufall = random.Next(3);
            switch (botWahlZufall)
            {
                case 0:
                    botWahl.Schere = true;
                    break;
                case 1:
                    botWahl.Stein = true;
                    break;
                case 2:
                    botWahl.Papier = true;
                    break;
            }

            SpielerWahl_SchereSteinPapier spielerWahl = _context.SpielerWahl_SchereSteinPapier.LastOrDefault();
            Punktezahl_SchereSteinPapier aktuellesSpiel = _context.Punktezahl_SchereSteinPapier.FirstOrDefault();
            if (spielerWahl == null || aktuellesSpiel == null)
            {
                return NotFound("Keine Spielerwahl oder kein aktives Spiel gefunden.");
            }

            // Vergleiche die Wahlen und aktualisiere die Punktzahl
            if ((spielerWahl.Schere && botWahl.Papier) ||
                (spielerWahl.Stein && botWahl.Schere) ||
                (spielerWahl.Papier && botWahl.Stein))
            {
                aktuellesSpiel.PunkteSpieler++;                
            }
            else if ((spielerWahl.Schere && botWahl.Stein) ||
                     (spielerWahl.Stein && botWahl.Papier) ||
                     (spielerWahl.Papier && botWahl.Schere))
            {
                aktuellesSpiel.PunkteBot++;               
            }

            _context.SaveChanges();
            return new GameResult_SchereSteinPapier {SpielerWahl = spielerWahl, BotWahl = botWahl, Punktezahl = aktuellesSpiel };
        }
    }
}
