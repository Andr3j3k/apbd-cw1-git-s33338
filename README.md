# apbd-cw1-git-s33338
## Zadanie 5
Przykład merge bez fast-forward

Merge nie był fast-forward, ponieważ po utworzeniu gałęzi `feature-max` został wykonany dodatkowy, niezależny commit bezpośrednio na `main`. W efekcie gałęzie miały różną historię i Git musiał utworzyć zwykły merge.

## Zadanie 6
Ćwiczenie rebase dla gałęzi feature-min

Po rebase commity z gałęzi `feature-min` zostały przeniesione na szczyt aktualnej gałęzi `main`. Dzięki temu historia jest bardziej liniowa i końcowy merge do `main` nie wymagał osobnego merge commita.

### 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
Fast-forward jest możliwy wtedy, gdy gałąź docelowa nie ma nowych commitów od momentu utworzenia drugiej gałęzi. W takiej sytuacji Git tylko przesuwa wskaźnik gałęzi do przodu. Merge commit powstaje wtedy, gdy obie gałęzie mają własne nowe commity i ich historia się rozeszła.

### 2. Czym w praktyce różni się merge od rebase?
Merge łączy historię dwóch gałęzi i zachowuje informację o ich rozdzieleniu, często tworząc dodatkowy merge commit. Rebase przenosi commity z jednej gałęzi na koniec drugiej, dzięki czemu historia jest bardziej liniowa i uporządkowana.

### 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
Konflikt został wywołany przez zmianę tego samego fragmentu kodu w gałęzi `feature-conflict` i w gałęzi `main`. Został rozwiązany ręcznie w edytorze merge w Riderze przez wybranie jednej końcowej, wspólnej wersji komunikatu, tak aby kod po scaleniu dalej działał poprawnie.