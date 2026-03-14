# apbd-cw1-git-s33338
## Zadanie 5
Przykład merge bez fast-forward

Merge nie był fast-forward, ponieważ po utworzeniu gałęzi `feature-max` został wykonany dodatkowy, niezależny commit bezpośrednio na `main`. W efekcie gałęzie miały różną historię i Git musiał utworzyć zwykły merge.

## Zadanie 6
Ćwiczenie rebase dla gałęzi feature-min

Po rebase commity z gałęzi `feature-min` zostały przeniesione na szczyt aktualnej gałęzi `main`. Dzięki temu historia jest bardziej liniowa i końcowy merge do `main` nie wymagał osobnego merge commita.