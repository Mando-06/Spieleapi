function Anleitung() {
    alert("Im Russian Roulette musst du gegen einen Bot ums überleben kämpfen und als alternative gibt es das Klassische Schere Stein Papier.");
}


function startRussianRoulette() {
    fetch('https://localhost:7108/api/RussianRoulette', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.json())
    .then(data => {
        if (data && data.spieler && data.spieler.id !== undefined) {
            currentGameId = data.spieler.id;
            updateGameStatus(data);
            document.getElementById('russianRouletteGame').classList.remove('hidden');
            document.getElementById('playButton').textContent = "Abzug betätigen";
        } else {
            throw new Error('Unerwartetes Antwortformat');
        }
    })
    .catch(error => {
        console.error('Fehler beim Starten von Russian Roulette:', error);
        alert('Fehler beim Starten des Spiels.');
    });
}

function playGame() {
    if (currentGameId === null) {
        startRussianRoulette();
    } else {
        fetch(`https://localhost:7108/api/RussianRoulette/${currentGameId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            }
        })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.text();
        })
        .then(data => {
            if (data === "You Lost") {
                throw new Error('You Lost');
            } else {
                updateGameStatus(JSON.parse(data));
            }
        })
        .catch(error => {
            if (error.message === 'You Lost') {
                document.getElementById('gameResult').textContent = "Du hast verloren. Versuche es noch einmal!";
            } else {
                console.error('Fehler beim Spielen von Russian Roulette:', error);
                alert('Fehler beim Spielen.');
            }
        });
    }
}

function updateGameStatus(data) {
    document.getElementById('playerLife').textContent = "Spieler Leben: " + data.spieler.leben;
    document.getElementById('botLife').textContent = "Bot Leben: " + data.bot.leben;
    document.getElementById('turn').textContent = data.spieler.istSpielerAmZug ? "Du bist an der Reihe" : "Bot ist an der Reihe";

    if (!data.spieler.amLeben || !data.bot.amLeben) {
        let endMessage = data.spieler.amLeben ? "Du überlebst! Dein Gegner war so dumm sich 3 Mal in den Kopf zu schiessen!" : "Du hast dir 3 Mal in den Kopf Geschossen! Du bist ein Looser:)";
        document.getElementById('gameResult').textContent = endMessage;
        document.getElementById('playButton').textContent = "Zurück zum Menü";
        document.getElementById('playButton').onclick = returnToMenu;
    }
}

document.getElementById('playButton').addEventListener('click', playGame);

function startRockPaperScissors() {
    document.getElementById('rockPaperScissorsGame').classList.remove('hidden');
}

function makeChoice(playerChoice) {
    fetch('https://localhost:7108/api/SchereSteinPapier', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            spielerWahl: {
                id: 1,
                schere: playerChoice === "scissors",
                stein: playerChoice === "rock",
                papier: playerChoice === "paper"
            }
        })
    })
    .then(response => {
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        return response.json();
    })
    .then(data => {
        let botChoice = '';
        if (data.botWahl.schere) {
            botChoice = 'Schere';
        } 
        if (data.botWahl.stein) {
            botChoice = 'Stein';
        } 
        if (data.botWahl.papier) {
            botChoice = 'Papier';
        }
        if (botChoice !== '') {
            document.getElementById('botChoice').textContent = "Der Bot hat gewählt: " + botChoice;
        } else {
            document.getElementById('botChoice').textContent = "Der Bot hat besseres zu tun als mit dir zu Spielen.";
        }
        document.getElementById('gameResult').textContent = data.punktezahl.PunkteSpieler + " : " + data.punktezahl.PunkteBot;
    })
    .catch(error => {
        console.error('Fehler beim Starten des Schere-Stein-Papier-Spiels:', error);
        alert('Fehler beim Starten des Spiels.');
    });
}


// Event Listener für die Schere, Stein und Papier Buttons
document.getElementById('scissorsButton').addEventListener('click', function() {
    makeChoice("scissors");
});

document.getElementById('rockButton').addEventListener('click', function() {
    makeChoice("rock");
});

document.getElementById('paperButton').addEventListener('click', function() {
    makeChoice("paper");
});

// Event Listener für das Neustarten des Spiels zuweisen
document.getElementById('playButton').addEventListener('click', playGame);
