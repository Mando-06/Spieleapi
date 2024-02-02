async function startNewGame() {
  try {
    const response = await fetch(
      "https://localhost:7003/Roulette/StartNewGame"
    );
    const result = await response.text();
    document.getElementById("result").innerText = result;
  } catch (error) {
    console.error("Error starting new game:", error);
    document.getElementById("result").innerText = "Error starting new game.";
  }
}

async function pullTrigger() {
  try {
    const response = await fetch("https://localhost:7003/Roulette/PullTrigger");
    const result = await response.text();
    document.getElementById("result").innerText = result;
  } catch (error) {
    console.error("Error pulling trigger:", error);
    document.getElementById("result").innerText = "Error pulling trigger.";
  }
}

function showGame(gameId) {
  // Startseite und alle Spiele verstecken
  document.getElementById('startPage').style.display = 'none';
  document.getElementById('russianRoulette').style.display = 'none';
  document.getElementById('rockPaperScissors').style.display = 'none';

  if (gameId === 'startPage') {
      document.getElementById('startPage').style.display = 'block';
  } else {
      document.getElementById(gameId).style.display = 'block';
  }
}

