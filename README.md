# HTL-VRProject with XRInteractionToolkit by Linda Pizzato

## Beschreibung
Nach dem Eintreten in ein Labyrinth schließt sich die Tür hinter einem. Hier drinnen sind Ostereier verstreut, in denen Rätsel versteckt sind. Insgesamt sind es 4 Richtige, der Rest sind Fake-Eier!
Die Rätsel in diesen Eiern führen auf eine falsche Fährte. Nach etwas Zeit wird man sie aber am Sound auseinanderhalten können.
Die Zahlen, die bei den richtigen Rästeln als Lösung herausgefunden werden, müssen bei farblich abgestimmten Checkpoints eingegeben werden (Osterei muss die gleiche Farbe haben wie der Checkpoint).
Stimmen die eingegebenen Zahlen, erscheinen Sie automatisch auf den Buttons, die gegen Ende dese Labyrinths in einer Nische entdeckt werden. Jeder Button hat also jetzt eine Zahl darauf und gibt einen Sound von sich, wenn man ihn betätigt.
In der richtigen Reihenfolge abgespielt, ergeben alle Buttons zusammen ein Soundmuster. In dieser Reihenfolge müssen die Zahlen jetzt beim Zahlenschloss auch eingegeben werden.
Den kurzen Weg von den Buttons zum Zahlenschluss muss der Spieler sich die Zahlen sowie die Reihenfolge dieser merken. Wenn alles stimmt, öffnet sich jetzt die Tür zum Ausgang!

## Spaßfaktor
Die Rätsel bestehen aus Programmiercodes, was den Spielspaß für Interessierte enorm erhöht. Die richtige Soundreihenfolge zu finden ist weder recht einfach, noch frustrierend schwer, weshalb es Spaß macht, die Lösung herauszufinden. Auch das Zahlenschloss gestaltet sich eher einfach, aber keineswegs langweilig.
So besteht dieses VR Spiel aus 2 sehr unterschiedlichen Aufgaben, was es spannend macht und auch bleiben lässt.

## Skizze
![Skizze](https://user-images.githubusercontent.com/72389401/168030256-a4b7e302-fdd3-48ff-9e17-3735498b3b8e.png)

## Minigame: "Ostereier-Code-Rätsel"
Im Labyrinth sind verschiedene bunte Ostereier verstreut. 4 davon haben leicht andere Sounds als der Rest, in ihnen verstecken sich 4 Rätsel, aus denen 4 Zahlen als Lösung hervorgehen.
Findet man ein richtiges Osterei und öffnet es, befindet sich darin ein Programmierrätsel, z.B.: ein if-Statement, bei dem am Ende eine Zahl herauskommt. Angenommen diese Zahl ist “4” und das Osterei grün, muss man jetzt den grünen Checkpoint suchen und die Zahl 4 eingeben. Das kann man mit einem Button, wo die Zahlen 1-9 durchgeklickt und dann auch bestätigt werden können.
Sind alle Zahlen bei allen Checkpoints richtig, öffnet sich die Ausgangstüre des Maze.
Je länger man für das Spiel benötigt, desto mehr Hinweise treten auf den Wänden nach und nach auf.

## Arbeitsschritte
1. Recherche: Ostereier öffnen, wie?
2. Überlegung & Recherche: Wie werden die Rätsel angezeigt? Overlays? Wie auf Papier?
3. Sounds heraussuchen
4. Wie sehen die Checkpoints aus?
5. Überlegung: Wird an den Checkpoints direkt festgestellt, ob die eingegebene Zahl richtig ist?
6. Rätsel überlegen & erstellen
7. Testing: aufgeteilte Sounds auf Buttons: hört man den zusammenhängenden Sound heraus?
8. Spielanleitung? Wie erkläre ich dem User, was zu tun ist?
9. Dokumentation erstellen
10. Modellieren des Zahlenschlosses
11. Testing: Bei richtiger Eingabe der Zahlen an den Checkpoints -> Anzeige auf Buttons -> richtige Reihenfolge für Zahlenschloss
12. Testing: Passt Hintergrundmusik oder stört sie? Wenn ja, wann hört sie auf (bei Buttons?)
13. Whiteboxing: Ostereier & Checkpoints
14. Testing: Passen die Positionen von Ostereiern & Checkpoints?
15. Feature: Random Rätsel- & Zahlenreihenfolge

## Assets
Eastereggs: https://free3d.com/3d-model/egg-370117.html 
LeanTween: https://assetstore.unity.com/packages/tools/animation/leantween-3595 
8K Skybox Pack Free: https://assetstore.unity.com/packages/2d/textures-materials/sky/8k-skybox-pack-free-150926

## Sounds
- 2 Ostereier-Sounds, die ähnlich klingen: https://www.epidemicsound.com/sound-effects/search?term=ice%20bells ("Ice Cream Truck Bell 2" & "8", edited in Adobe Audition)
- Atmo
- leise Hintergrundmusik? (hört bei Buttons auf?)
- Oster-Soundtheme, dass durch 4 geteilt wird (für die Buttons)
- Checksound wenn Zahlen bei Checkpoints richtig eingegeben werden (?)
- Zahlenschloss-Sounds (drehen, einrasten)
- Tür-Öffnen & -Schließen Sound

## Fonts
Consolas: https://www.dafontfree.io/consolas-font/

## Software/Hardware Requirements:

Oculus hardware requirements  [https://support.oculus.com/248749509016567/](https://support.oculus.com/248749509016567/)  You need a VR headset in this case an Oculus Rift/Quest/Quest2

Examples:  [https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples)

When downlaoded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

### Target platform:
Oculus Rift/S; Quest/2

### Third party material:
For testing without a headset, use the XR Device Simulator (included in the xr interaction toolkit package):  [https://www.youtube.com/watch?v=d4bTpkvBwrs](https://www.youtube.com/watch?v=d4bTpkvBwrs)

*Copyright by Linda Pizzato*
