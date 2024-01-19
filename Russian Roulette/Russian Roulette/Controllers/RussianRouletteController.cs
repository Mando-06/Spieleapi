using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RouletteController : ControllerBase
{
    public int Lives = 3;
    private static readonly int Chambers = 6;
    private int loadedChamberIndex = 0;
    private int currentPosition = 0;
    private int shotsTaken = 0; // New variable to count shots
    private bool gameOver = false; // New variable to track game over state
    private static readonly Random Random = new Random();

    [HttpGet("StartNewGame", Name = "StartNewGame")]
    public ActionResult<string> StartNewGame()
    {
        currentPosition = 0;
        shotsTaken = 0;
        gameOver = false; // Reset game over state
        return "Neues Spiel gestartet. Spiele Russisches Roulette!";
    }

    [HttpGet("PullTrigger", Name = "PullTrigger")]
    public ActionResult<string> PullTrigger()
    {
        shotsTaken++;

        if (!gameOver && shotsTaken < Chambers)
        {
            ShuffleRevolver(); // Shuffle the revolver only once per trigger pull

            if (currentPosition == loadedChamberIndex)
            {
                Lives--;
                gameOver = true;
                return $"Bang! Du hast verloren. Verbleibende Leben: {Lives}. Verwende StartNewGame, um erneut zu spielen.";
            }
            else
            {
                currentPosition++; // Increment the currentPosition after each shot
                return $"Klick! Du hast überlebt. Schuss {shotsTaken} von {Chambers}. Schiesse erneut.";
            }
        }
        else
        {
            return "Das Spiel ist vorbei. Verwende StartNewGame, um ein neues Spiel zu beginnen.";
        }
    }


    private void ShuffleRevolver()
    {
        loadedChamberIndex = Random.Next(0, Chambers + 1);
    }
}
