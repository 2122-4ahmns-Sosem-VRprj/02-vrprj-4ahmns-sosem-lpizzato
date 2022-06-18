# HTL-VRProject with XRInteractionToolkit by Linda Pizzato

## Beschreibung
Nach dem Eintreten in ein Labyrinth schließt sich die Tür hinter einem. Hier drinnen sind Ostereier verstreut, in denen Rätsel versteckt sind. Insgesamt sind es 4 Richtige, der Rest sind Fake-Eier!
Die Rätsel in diesen Eiern führen auf eine falsche Fährte. Nach etwas Zeit wird man sie aber am Sound auseinanderhalten können.
Die Zahlen, die bei den richtigen Rästeln als Lösung herausgefunden werden, müssen bei farblich abgestimmten Checkpoints eingegeben & bestätigt werden (Osterei muss die gleiche Farbe haben wie der Checkpoint). 
Wer Schwierigkeiten im Spiel hat, dem wird mit Hinweisen geholfen, die je länger man braucht an den Labyrinthwänden erscheinen.
 Wenn alles stimmt, öffnet sich jetzt die Tür zum Ausgang!

## Spaßfaktor
Die Rätsel bestehen aus Programmiercodes, was den Spielspaß für Interessierte enorm erhöht. Es ist nicht allzu einfach, die Codes zu finden und zu lösen, und wird auch nicht zu schwer, da mit der Zeit immer mehr Hinweise erscheinen.

## Skizze
![Skizze](https://user-images.githubusercontent.com/72389401/168030256-a4b7e302-fdd3-48ff-9e17-3735498b3b8e.png)

## Minigame: "Ostereier-Code-Rätsel"
Im Labyrinth sind verschiedene bunte Ostereier verstreut. 4 davon haben leicht andere Sounds als der Rest, in ihnen verstecken sich 4 Rätsel, aus denen 4 Zahlen als Lösung hervorgehen.
Findet man ein richtiges Osterei und öffnet es, befindet sich darin ein Programmierrätsel, z.B.: ein if-Statement, bei dem am Ende eine Zahl herauskommt. Angenommen diese Zahl ist “4” und das Osterei grün, muss man jetzt den grünen Checkpoint suchen und die Zahl 4 eingeben. Das kann man mit einem Button, wo die Zahlen 1-9 durchgeklickt und dann auch bestätigt werden können.
Sind alle Zahlen bei allen Checkpoints richtig, öffnet sich die Ausgangstüre des Maze.
Je länger man für das Spiel benötigt, desto mehr Hinweise treten auf den Wänden nach und nach auf.

## Arbeitsschritte
1. Rätsel erstellen
2. Ostereier Assets suchen
3. Ostereier mit den richten Rätsel verbinden & On Activate
4. Checkpoint Assets erstellen
5. Checkpoint-Script: Counting-Up-Button & Confirm-Button
6. Sounds für Ostereier
7. Hintergrundmusik
8. Sounds für Intro & Outro
9. Anleitung fürs Intro & Outro-Text
10. Labyrinth texturieren
11. Neue Skybox
12. Hinweise überlegen & erstellen 
13. Hinweise: nach einer gewissen Zeit in einem gewissen Intervall
14. Dokumentation
15. Testing

## Assets
- Eastereggs: https://free3d.com/3d-model/egg-370117.html
- LeanTween: https://assetstore.unity.com/packages/tools/animation/leantween-3595
- 8K Skybox Pack Free: https://assetstore.unity.com/packages/2d/textures-materials/sky/8k-skybox-pack-free-150926

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
