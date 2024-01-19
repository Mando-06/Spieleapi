# Spiele Api

# Projekt-Dokumentation

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                                                                                                             |
| ----- | ------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in _einem_ Satz, was Sie erreicht haben. |
|       | ...     |                                                                                                                                             |
|       | 1.0.0   |                                                  |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ           | Beschreibung                  |
| ---- | --------------- | ------------- | ----------------------------- |
| 1    | Muss            | Funktional    | Als ein User möchte ich Schere, Stein oder Papier spielen können.                                                                           |
| 2    | Muss            | Funktional    | Als ein User möchte ich Russian Roulette spielen können. |
| 3    | Muss            | Funktional    | Als ein User möchte ich zwischen Schere, Stein und Papier wählen können, damit ich das Spiel spielen kann.     |
| 4    | Muss            | Funktional    |  Als ein User möchte ich, auswählen können, ob ich Schere,Stein,Papier oder Russian Roulette spielen möchte.  |
| 5    | Muss            | Funktional    | Als ein User möchte ich gegen andere Personen spielen können.        |
| 6    | Muss            | Funktional    | Als ein User möchte ich gegen einen Bot spielen können.   |
| 7   | Muss    | Funktional    |    Als ein User möchte ich, zwischen zwei verschiedenen Waffen auswählen können. |
| 8    | Muss    | Qualität  | Als ein User möchte ich, dass es nur ein Schuss in der Waffe hat, damit nur ein Spieler stirbt. |
| 9    |  Muss  | Funktional   | Als ein User möchte ich, dass es einen Soundeffekte gibt, wenn die Waffe einen Schuss abgibt im Russian Roulette, damit die Spielerfahrung intensiver wird. |
| 10 | Muss | Funktional  | Als ein User möchte ich, dass ich Items bekommen kann, damit ich mehr Spielvarianten habe.
| 11    | Muss            | Funktional    | Als ein User möchte ich, dass es eine Anleitung gibt, damit ich sehen kann, wie ich Scheren, Stein, Papier oder Russian Roulette spielen kann. |
| 12    | Muss            | Qualität      | Als ein User möchte ich, dass Fehleingaben abgefangen werden.  |
| 13   | Muss            | Qualität      | Als ein User möchte ich, dass das Frontend benutzerfreundlich gestaltet ist.                                  |
| 14   | Muss            | Randbedingung | Als ein User möchte ich, dass die Spiele über eine API laufen.       |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm ist gestartet  | Schere  | Schere         |
| 1.2  | Programm ist gestartet     |  Schere       |  Stein             |
| 1.3  | Programm ist gestartet    |  Schere       |  Papier                 |
| 1.4  | Programm ist gestartet   | Stein        | Stein                  |
| 1.5  | Programm ist gestartet    | Stein        | Schere                 |
| 1.6  | Programm ist gestartet    | Stein        | Papier                 |
| 1.7  | Programm ist gestartet   | Papier        |  Papier                 |
| 1.8  | Programm ist gestartet       | Papier        |  Stein               |
| 1.9  | Programm ist gestartet    | Papier        |  Schere                 |
| 2.1  | Programm ist gestartet    | Russian Roulette anklicken  |            |
| 3.1  | Schere, Stein, Papier ausgewählt       | Spiel starten anklicken  |                   |
| 4.1  | Programm ist gestartet  | Schere,Stein,Papier oder Russian Roulette anklicken  | Spiel startet     |
| 5.1  | Spiel ausgewählt      | 1 vs 1 anklicken  | Spiel startet       |
| 6.1  | Spiel ausgewählt      | gegen Bot spielen anklicken   | Spiel startet  |
| 7.1  | Russian Roulette ausgewählt  | Waffe auswählen | Spiel startet  |
| 8.1  | Russian Roulette ausgewählt  | Pull Trigger|                   |
| 8.2  | Russian Roulette ausgewählt  | Pull Trigger|                   |
| 9.1  | Pulled Trigger  | -     | Schuss sound                  |
| 10.1  |Russian Roulette ausgewählt|Wahl Item         | Item ausgewählt                  |
| 11.1  |Programm ist gestartet |klick auf Spielanleitung  | Spielanleitung                  |
| 12.1 | Programm ist gestartet  |Fehleingabe         | Ungültige Eingabe     |
| 13.1  | Programm ist gestartet | -        | benutzerfreundliches Frontend   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total:

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.