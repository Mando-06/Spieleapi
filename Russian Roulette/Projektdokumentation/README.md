# Spiele Api

# Projekt-Dokumentation

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                                                                                                             |
| ----- | ------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in _einem_ Satz, was Sie erreicht haben. |
|       | ...     |                                                                                                                                             |
|       | 1.0.0   |                                                                                                                                             |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ           | Beschreibung                                                                                                                           |
| ---- | --------------- | ------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional    | Als ein User möchte ich Schere, Stein Papier spielen können.                                                                           |
| 2    | Muss            | Funktional    | Als ein User möchte ich Roulette spielen können.                                                                                       |
| 3    | Muss            | Funktional    | Als ein User möchte ich zwischen Schere, Stein und Papier wählen können, damit ich das Spiel spielen kann.                                  |
| 4    | Muss            | Funktional    | Als ein User möchte ich, dass ich auf eine bestimmte Zahl, oder gerade oder ungerade Zahlen setzen.                                    |
| 5    | Muss            | Funktional    | Als ein User möchte ich, dass ich auf Zahlen von 0 - 35 wetten kann.                                                                   |
| 6    | Muss            | Funktional    | ALs ein User möchte ich, dass das Roulette über ein Konto verfügt, in welchem mir die Chips angezeigt werden, die ich besitze.         |
| 7    | Muss            | Funktional    | Als ein User möchte ich, dass es eine Anleitung gibt, damit ich sehen kann, wie ich Scheren, Stein, Papier oder Roulette spielen kann. |
| 8    | Muss            | Qualität      | Als ein User möchte ich, dass Fehleingaben abgefangen werden.                                                                          |
| 9    | Muss            | Qualität      | Als ein User möchte ich, dass das Frontend benutzerfreundlich gestaltet ist.                                                           |
| 10   | Muss            | Randbedingung | Als ein User möchte ich, dass die Spiele über eine API laufen.                                                                         |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm ist gestartet  | Schere  | Schere         |
| 1.2  | Programm ist gestartet             |  Schere       |  Stein                 |
| 1.3  | Programm ist gestartet             |  Schere       |  Papier                 |
| 1.4  | Programm ist gestartet             | Stein        | Stein                  |
| 1.5  | Programm ist gestartet             | Stein        | Schere                 |
| 1.6  | Programm ist gestartet             | Stein        | Papier                 |
| 1.7  | Programm ist gestartet             | Papier        |  Papier                 |
| 1.8  | Programm ist gestartet             | Papier        |  Stein               |
| 1.9  | Programm ist gestartet             | Papier        |  Schere                 |
| 2.1  | Programm ist gestartet             |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
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
