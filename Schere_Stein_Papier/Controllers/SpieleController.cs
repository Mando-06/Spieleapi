using Microsoft.AspNetCore.Mvc;
using Schere_Stein_Papier.Data;
using Schere_Stein_Papier.Models;
using System.Data.Entity;

namespace Schere_Stein_Papier.Controllers
{
    public class SpieleController : ControllerBase
    {
        private readonly ApiContext _context;

        public SpieleController(ApiContext context)
        {
            _context = context;
        }

        public class GameResult
        {
            public Spieler Spieler { get; set; }
            public Bot Bot { get; set; }
            
        }

        // Create
        [HttpPost]
        public IActionResult CreateEdit(SpielAPI spielApi)
        {
            
            if (spielApi.Id == 0)
            {
                var spiel = new SpielAPI();
                _context.Spiele.Add(spiel); 
            }
            else
            {
                var spielInDb = _context.Spiele.Find(spielApi.Id);
                if (spielInDb == null)
                    return NotFound();
            }

            _context.SaveChanges();
            return Ok(spielApi);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSpiel(int id, SpielAPI spielApi)
        {
            if (id != spielApi.Id)
            {
                return BadRequest();
            }

            _context.Entry(spielApi).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetSpiel(int id)
        {
            var spiel = _context.Spiele.Find(id);
            if (spiel == null)
            {
                return NotFound();
            }
            return Ok(spiel);
        }

        // Spiel Logik
        [HttpPost("Start")]
        public IActionResult StartSpiel(string inputPlayer)
        {
            string[] options = { "Schere", "Stein", "Papier" };
            Random random = new Random();

            string inputComputer = options[random.Next(options.Length)];

            string result = DetermineWinner(inputPlayer, inputComputer);

            return Ok(new { PlayerChoice = inputPlayer, ComputerChoice = inputComputer, Result = result });
        }

        private string DetermineWinner(string inputPlayer, string inputComputer)
        {
            if (inputPlayer == inputComputer)
            {
                return "Unentschieden";
            }
            else if ((inputPlayer == "Schere" && inputComputer == "Papier") ||
                     (inputPlayer == "Stein" && inputComputer == "Schere") ||
                     (inputPlayer == "Papier" && inputComputer == "Stein"))
            {
                return "Spieler gewinnt";
            }
            else
            {
                return "Computer gewinnt";
            }
        }

    }
}
