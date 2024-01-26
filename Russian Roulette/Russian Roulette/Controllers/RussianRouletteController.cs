using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RouletteController : ControllerBase
{
    public int Lives = 3;
    private static readonly int Chambers = 6;
    private int loadedChamberIndex = 0;
    private int currentPosition = 0;
    private int shotsTaken = 0;
    private bool gameOver = false;
    private static readonly Random Random = new Random();

    [HttpGet("StartNewGame", Name = "StartNewGame")]
    public ActionResult<string> StartNewGame()
    {
        currentPosition = 0;
        shotsTaken = 0;
        gameOver = false;
        return "Neues Spiel gestartet. Spiele Russisches Roulette!";
    }

    [HttpGet("PullTrigger", Name = "PullTrigger")]
    public ActionResult<string> PullTrigger()
    {
        shotsTaken++;

        if (!gameOver && shotsTaken <= Chambers)
        {
            ShuffleRevolver();

            if (currentPosition == loadedChamberIndex)
            {
                Lives--;

                if (Lives <= 0)
                {
                    Lives = 0;
                    gameOver = true;
                    return $"Bang! Du hast verloren. Verbleibende Leben: {Lives}. Verwende 'Reload Chambers', um erneut zu spielen.";
                }

                return $"Bang! Du hast verloren. Verbleibende Leben: {Lives}. Schiesse erneut.";
            }
            else
            {
                currentPosition++;

                if (shotsTaken == Chambers)
                {
                    gameOver = true;
                    return $"Klick! Du hast überlebt. Schuss {shotsTaken} von {Chambers}. Verwende 'Reload Chambers', um ein neues Spiel zu beginnen.";
                }

                return $"Klick! Du hast überlebt. Schuss {shotsTaken} von {Chambers}. Schiesse erneut.";
            }
        }

        else
        {
            return "Das Spiel ist vorbei";
        }
    }

    private void ShuffleRevolver()
    {
        loadedChamberIndex = Random.Next(0, Chambers);
    }
}
