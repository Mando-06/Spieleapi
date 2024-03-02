let currentGameId = null; // Globale Variable, um die Spiel-ID zu speichern

// Funktion zum Starten eines neuen Spiels
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
            currentGameId = data.spieler.id; // Speichere die ID des Spielers
            updateGameStatus(data);
            document.getElementById('russianRouletteGame').classList.remove('hidden');
            const playButton = document.getElementById('playButton');
            if(playButton) {
                playButton.textContent = "Schießen";
            }
        } else {
            throw new Error('Unerwartetes Antwortformat');
        }
    })
    .catch(error => {
        console.error('Fehler beim Starten von Russian Roulette:', error);
        alert('Fehler beim Starten des Spiels. Siehe Konsole für mehr Informationen.');
    });
}

// Funktion zum Spielen des Spiels nach dem Start
function playGame() {
    if (currentGameId === null) {
        alert('Spiel ist nicht gestartet oder Spiel-ID ist unbekannt.');
        return;
    }

    fetch(`https://localhost:7108/api/RussianRoulette/${currentGameId}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    })
    .then(response => response.json())
    .then(data => updateGameStatus(data))
    .catch(error => {
        console.error('Fehler beim Spielen von Russian Roulette:', error);
        alert('Fehler beim Spielen. Siehe Konsole für mehr Informationen.');
    });
}

// Funktion zum Aktualisieren des Spielstatus
function updateGameStatus(data) {
    if (data.spieler && data.bot) { // Stelle sicher, dass die notwendigen Daten vorhanden sind
        document.getElementById('playerLife').textContent = "Spieler Leben: " + data.spieler.leben;
        document.getElementById('botLife').textContent = "Bot Leben: " + data.bot.leben;
        document.getElementById('turn').textContent = data.spieler.istSpielerAmZug ? "Spieler ist an der Reihe" : "Bot ist an der Reihe";
        document.getElementById('gameResult').textContent = "";
    } else {
        console.error('Unerwartetes Antwortformat:', data);
        alert('Fehler beim Aktualisieren des Spielstatus. Unerwartetes Antwortformat.');
    }
}


// Funktion zum Starten des Schere-Stein-Papier-Spiels
function startRockPaperScissors() {
    // Platzhalter für die Implementierung des Schere-Stein-Papier-Spiels
    alert('Schere-Stein-Papier noch nicht implementiert.');
}
