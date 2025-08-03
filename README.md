Dieses Projekt ist eine Umsetzung des Spiels Arkanoid. Ziel ist es,
alle Blöcke mithilfe des Balls und des Paddles zu zerstören.
Wenn der Ball drei Mal den Boden berührt, hat man verloren.

Gesteuert werden kann das Paddle mit den Tasten "A" und "D" oder
der linken und rechten Pfeiltaste.

Es gibt drei Powerups, die man hierbei aufsammeln kann:

1. Macht das Paddle breiter (Blau)
2. Verlangsamt das Spiel (Grün)
3. Spawnt einen weiteren Ball (Rot)

Nachdem ein Block zerstört wurde, spawnt mit einer Chance von 20%
ein Powerup. Welches von den drei dann spawnt, ist zufällig. Dies
geschieht im Block-Skript. Für die drei Powerups wurden jeweils
separate Skripts verwendet.

Die Farben der Blöcke werden bei jedem Neustart der Szene zufällig
generiert. Wie oft ein Block getroffen werden muss, wird ebenfalls
durch einen zufällig Wert zwischen 1 und 5 entschieden. Dies
geschieht ebenfalls im Block-Skript.

Bekannte Bugs/Fehler:

1. Manchmal, wenn der Ball genau zwischen zwei Blöcke fliegt (obwohl
dort durch Snapping keine Lücke sein sollte) fliegt der Ball
einfach durch und es wird keine Kollision erkannt. Was die Ursache
davon ist, konnte ich leider trotz intensiver Überprüfung nicht
herausfinden und fixen.

2. Eigentlich war für den Victory-Screen ein Restart-Button geplant,
aber aus irgendeinem Grund funktioniert dieser nur beim GameOver-
Screen. Dies konnte trotz Ihrer Vorschläge nicht behoben werden.
