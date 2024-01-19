using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RouletteController : ControllerBase
{
    private static readonly int Chambers = 6;
    private static readonly List<int> Revolver = new List<int>();
    private static readonly Random Random = new Random();

    private int loadedChamberIndex = -1; // Index der geladenen Kammer

    [HttpGet("StartNewGame", Name = "StartNewGame")]
    public ActionResult<string> StartNewGame()
    {
        lock (Revolver)
        {
            Revolver.Clear();
            Revolver.AddRange(Enumerable.Repeat(0, Chambers));
            loadedChamberIndex = Random.Next(Chambers); // Zufällige geladene Kammer
            ShuffleRevolver();
        }

        return "New game started. Play Russian Roulette!";
    }

    [HttpGet("SpinRevolver", Name = "SpinRevolver")]
    public ActionResult<string> SpinRevolver()
    {
        lock (Revolver)
        {
            if (Revolver.Count == 0)
            {
                return "No game started. Use StartNewGame to begin a new game.";
            }

            ShuffleRevolver();

            return "Revolver spun. Now pull the trigger!";
        }
    }

    [HttpGet("PullTrigger", Name = "PullTrigger")]
    public ActionResult<string> PullTrigger()
    {
        lock (Revolver)
        {
            if (Revolver.Count == 0)
            {
                return "No game started. Use StartNewGame to begin a new game.";
            }

            if (loadedChamberIndex == 0)
            {
                return "Bang! You lose. Play StartNewGame to play again.";
            }
            else
            {
                return "Click! You survived. Play SpinRevolver to play again.";
            }
        }
    }

    private void ShuffleRevolver()
    {
        for (int i = 0; i < Revolver.Count; i++)
        {
            int randomIndex = Random.Next(i, Revolver.Count);
            (Revolver[i], Revolver[randomIndex]) = (Revolver[randomIndex], Revolver[i]);
        }
    }
}
