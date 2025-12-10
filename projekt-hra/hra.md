# Hra


## 1. část - hráč
- udělejte herní pole (třeba 9 x 9)

- v herním poli bude hráč

- hráčem lze pohybovat pomocí příkazů `nahoru`, `dolu`, `doleva`, `doprava`


příklad terminálu:
```
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . # . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
kam?: 
```

<!-- <br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br> -->

## 2. část - poklad

- přidat "poklad" - v poli se na náhodné pozici objeví poklad `$`, ke kterému hráč musí dojít.
- když se hráč dostane na políčko, kde se poklad nachází, poklad se objeví na jiné pozici a hráči se přičte skóre.

příklad terminálu:
```
skore: 0
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . # . . . . .
. . . . . . . . .
. . . . . $ . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
kam?: 
```