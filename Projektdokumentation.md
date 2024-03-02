# Spiele Api

# Projekt-Dokumentation

Hitz, Sacher und Müller

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt setzen wir eine SpieleAPI um, mit der man Scheren Stein Papier und russisches Roulette spielen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ           | Beschreibung                                                                                                                                                |
| ---- | --------------- | ------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional    | Als ein User möchte ich Schere, Stein oder Papier spielen können.                                                                                           |
| 2    | Muss            | Funktional    | Als ein User möchte ich Russian Roulette spielen können.                                                                                                    |
| 3    | Muss            | Funktional    | Als ein User möchte ich zwischen Schere, Stein und Papier wählen können, damit ich das Spiel spielen kann.                                                  |
| 4    | Muss            | Funktional    | Als ein User möchte ich, auswählen können, ob ich Schere,Stein,Papier oder Russian Roulette spielen möchte.                                                 |
| 5    | Muss            | Funktional    | Als ein User möchte ich im Russian Roulette gegen andere Personen spielen können, damit man es mit Freunden lokal spielen kann.                             |
| 6    | Muss            | Funktional    | Als ein User möchte ich in beiden Spielen gegen einen Bot spielen können, damit man es auch ohne Freunde spielen kann.                                      |
| 7    | Muss            | Funktional    | Als ein User möchte ich, zwischen zwei verschiedenen Waffen auswählen können.                                                                               |
| 8    | Muss            | Qualität      | Als ein User möchte ich, dass es nur ein Schuss in der Waffe hat, damit nur ein Spieler stirbt.                                                             |
| 9    | Muss            | Funktional    | Als ein User möchte ich, dass es einen Soundeffekte gibt, wenn die Waffe einen Schuss abgibt im Russian Roulette, damit die Spielerfahrung intensiver wird. |
| 10   | Muss            | Funktional    | Als ein User möchte ich, dass ich Items bekommen kann, damit ich mehr Spielvarianten habe.                                                                  |
| 11   | Muss            | Funktional    | Als ein User möchte ich, dass es eine Anleitung gibt, damit ich sehen kann, wie ich Scheren, Stein, Papier oder Russian Roulette spielen kann.              |
| 12   | Muss            | Qualität      | Als ein User möchte ich, dass Fehleingaben abgefangen werden.                                                                                               |
| 13   | Muss            | Qualität      | Als ein User möchte ich, dass das Frontend benutzerfreundlich gestaltet ist.                                                                                |
| 14   | Muss            | Randbedingung | Als ein User möchte ich, dass die Spiele über eine API laufen.                                                                                              |

### 1.3 Testfälle

| TC-№ | Ausgangslage                     | Eingabe                                             | Erwartete Ausgabe                          |
| ---- | -------------------------------- | --------------------------------------------------- | ------------------------------------------ |
| 1.1  | Programm ist gestartet           | Schere                                              | Schere                                     |
| 1.2  | Programm ist gestartet           | Schere                                              | Stein                                      |
| 1.3  | Programm ist gestartet           | Schere                                              | Papier                                     |
| 1.4  | Programm ist gestartet           | Stein                                               | Stein                                      |
| 1.5  | Programm ist gestartet           | Stein                                               | Schere                                     |
| 1.6  | Programm ist gestartet           | Stein                                               | Papier                                     |
| 1.7  | Programm ist gestartet           | Papier                                              | Papier                                     |
| 1.8  | Programm ist gestartet           | Papier                                              | Stein                                      |
| 1.9  | Programm ist gestartet           | Papier                                              | Schere                                     |
| 2.1  | Programm ist gestartet           | Russian Roulette anklicken                          | GUI für russisches Roulette wird angezeigt |
| 3.1  | Schere, Stein, Papier ausgewählt | Spiel starten anklicken                             | Spiel startet                              |
| 4.1  | Programm ist gestartet           | Schere,Stein,Papier oder Russian Roulette anklicken | Spiel startet                              |
| 5.1  | Spiel ausgewählt                 | 1 vs 1 anklicken                                    | Spiel startet                              |
| 6.1  | Spiel ausgewählt                 | gegen Bot spielen anklicken                         | Spiel startet                              |
| 7.1  | Russian Roulette ausgewählt      | Waffe auswählen                                     | Spiel startet                              |
| 8.1  | Russian Roulette ausgewählt      | Pull Trigger Button drücken                         | kein Leben wird abgezogen                  |
| 8.2  | Russian Roulette ausgewählt      | Pull Trigger Button drücken                         | Leben wird abgezogen + Schuss sound        |
| 10.1 | Russian Roulette ausgewählt      | Wahl Item                                           | Item ausgewählt                            |
| 11.1 | Programm ist gestartet           | klick auf Spielanleitung                            | Spielanleitung                             |
| 12.1 | Programm ist gestartet           | Fehleingabe                                         | Ungültige Eingabe                          |
| 13.1 | Programm ist gestartet           | -                                                   | benutzerfreundliches Frontend              |

### 1.4 Diagramme

![Alt text](<Use Case Diagramm.png>)

## 2 Planen

| AP-№ | Frist      | Zuständig   | Beschreibung                  | geplante Zeit |
| ---- | ---------- | ----------- | ----------------------------- | ------------- |
| 1.A  | 05.02.2024 | Müller      | Schere Stein Papier           | 6\*45'        |
| 2.A  | 05.02.2024 | Sacher      | Russian Roulette              | 8\*45'        |
| 3.A  | 05.02.2024 | Müller      | Wahl bei Schere Stein Papier  | 45'           |
| 4.A  | 05.02.2024 | Hitz        | Spielauswahl                  | 45'           |
| 5.A  | 05.02.2024 | Sacher      | Multiplayer                   | 2\*45'        |
| 6.A  | 05.02.2024 | Sacher      | Computer Gegner               | 2\*45'        |
| 7.A  | 05.02.2024 | Hitz        | Waffenwahl Russian Roulette   | 2\*45'        |
| 8.A  | 05.02.2024 | Sacher      | Eine Kugel pro Waffe          | 45'           |
| 8.B  | 05.02.2024 | Hitz        | Schuss Sound                  | 45'           |
| 9.A  | 05.02.2024 | Hitz        | Itemwahl                      | 2\*45'        |
| 10.A | 05.02.2024 | Hitz        | Spielanleitungen              | 30'           |
| 11.A | 05.02.2024 | Müller      | Fehleingaben abfangen         | 45'           |
| 12.A | 05.02.2024 | Hitz        | Benutzerfreundliches Frontend | 45'           |
| 13.A | 05.02.2024 | Sacher      | API                           | 3\*45'        |
| 14.A | 05.02.2024 | Müller      | Testen                        | 30            |
| 15.A | 05.02.2024 | Individuell | Portfolio                     | 4\*45'        |

Total:

## 3 Entscheiden

Wir haben uns dazu entschieden, den Modus für lokales Zusammenspielen weg zu lassen.
Ausserdem haben wir uns dazu entschieden, die Items in dem russischen Roulette Spiel weg zu lassen.

## 4 Realisieren

| AP-№ | Datum             | Zuständig   | geplante Zeit | tatsächliche Zeit |
| ---- | ----------------- | ----------- | ------------- | ----------------- |
| 1.A  |  23.02.24                 | Müller      | 6\*45         |                   |
| 2.A  | 19.01. - 02.02.24 | Sacher      | 8\*45         | 12\*45'           |
| 3.A  | 26.01.24          | Müller      | 45            |                   |
| 4.A  |  23.02.24                 | Hitz        | 45            |                   |
| 5.A  | -                 | Sacher      | 2\*45         | -                 |
| 6.A  | 26.01.24          | Sacher      | 2\*45         | 30'               |
| 7.A  | 23.2.24                  | Hitz        | 2\*45         |                   |
| 8.A  | 26.01.24          | Sacher      | 45            | 15'               |
| 9.A  | 23.2.24                  | Hitz        | 45            |                   |
| 10.A |  23.2.24                 | Hitz        | 2\*45         |                   |
| 11.A | 23.2.24                  | Hitz        | 30            |                   |
| 12.A |   23.2.24                | Müller      | 45            |                   |
| 13.A |  23.2.24                 | Hitz        | 45            |                   |
| 14.A | 19.01.24          | Sacher      | 3\*45         | 45'               |
| 15   |  23.2.24                 | Müller      | 30            |                   |
| 16   |   1.3.24                   | Individuell | 4\*45         |                   |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum      | Resultat | Tester |
| ---- | ---------- | -------- | ------ |
| 1.1  | 01.03.2024 | OK ✅    | Sacher |
| 1.2  | 01.03.2024 | OK ✅    | Sacher |
| 1.4  | 01.03.2024 | OK ✅    | Sacher |
| 1.5  | 01.03.2024 | OK ✅    | Sacher |
| 1.6  | 01.03.2024 | OK ✅    | Sacher |
| 1.7  | 01.03.2024 | OK ✅    | Sacher |
| 1.8  | 01.03.2024 | OK ✅    | Sacher |
| 1.9  | 01.03.2024 | OK ✅    | Sacher |
| 2.1  | 01.03.2024 | OK ✅    | Sacher |
| 3.1  | 01.03.2024 | OK ✅    | Sacher |
| 4.1  | 01.03.2024 | OK ✅    | Sacher |
| 5.1  | 01.03.2024 | NOK ❌   | Sacher |
| 6.1  | 01.03.2024 | OK ✅    | Sacher |
| 7.1  | 01.03.2024 | NOK ❌   | Sacher |
| 8.1  | 01.03.2024 | OK ✅    | Sacher |
| 8.2  | 01.03.2024 | OK ✅    | Sacher |
| 9.1  | 01.03.2024 | OK ✅    | Sacher |
| 10.1 | 01.03.2024 | NOK ❌   | Sacher |
| 11.1 | 01.03.2024 | OK ✅    | Sacher |
| 12.1 | 01.03.2024 | OK ✅    | Sacher |

Die Testfälle, die nicht erfüllt wurden, also die Items, der lokale Multiplayer und die Auswahl der verschiedenen Waffen in dem russischen Roulette Spiel, lassen sich sehr gut in der Zukunft als Erweiterungen oder Updates hinzufügen. Trotz diesen fehlgeschlagenen Tests, ist die SpieleApi voll funktionsfähig und funktioniert ohne Fehler.

## 6 Auswerten

- Portfolioeintrag Robin Sacher: https://portfolio.bbbaden.ch/view/view.php?t=d14ea1bf74539810c87b
- Portfolioeintrag Julian Hitz: "Link zu Portfoliobeitrag"
- Portfolioeintrag Damian Müller: https://portfolio.bbbaden.ch/view/view.php?t=921690286c35cfb6bd6b
