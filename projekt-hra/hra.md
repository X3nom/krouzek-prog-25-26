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


## 3. část - had

- když hráč je had a pokaždé když sebere "poklad", prodlouží se o jedno políčko

- pokud hráč vjede sám do sebe, měla by hra vypsat `GAME OVER`

```
skore: 3
. . . . . . . . .
. . # . . . . . .
. . # . . . . . .
. . # # . . . . .
. . . . . . . . .
. . . . . $ . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
kam?: 
```

<!-- ### nápověda -->
<!-- - vždy když se hlava hada posune, odebere se část z konce ocasu -->

<!-- - technicky vzato se hlava nemusí posouvat, stačí přidat nový článek těla tam, kam se má posunout a odebrat poslední článek -->

<!-- - co by se dalo použít pro reprezentování hada? (přidáváme na jeden konec a z druhého konce mažeme) -->
