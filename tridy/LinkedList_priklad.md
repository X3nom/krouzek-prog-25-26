# Linked list
### co by měl umět:

- přidat
    - na začátek
    - na konec

- odebrat
    - ze začátku
    - z konce

- najít prvek


```C#
class Prvek
{

    public int hodnota;

    //    (pointer)
    public Prvek? dalsi = null;

    public Prvek? predchozi = null;

    public Prvek(int hodnota)
    {
        this.hodnota = hodnota;
    }

}


// uklada int
class LinkedList
{

    // promenna?
    // funkce?

    private Prvek zacatek;

    private Prvek konec;


    public void pridat(int x)
    { // na konec
        Prvek novy = new Prvek(x);

        // Máme prázdný seznam
        if (this.zacatek == null || this.konec == null)
        {
            this.zacatek = novy;
            this.konec = novy;
        }
        else
        {
            novy.predchozi = this.konec;
            this.konec.dalsi = novy;
            this.konec = novy;
        }
    }

    public void odebrat()
    { // z konce


    }

    public bool najit(int x)
    {
        Prvek? aktualni = this.zacatek;

        while (aktualni != null)
        {
            if (aktualni.hodnota == x)
            {
                return true;
            }
        }

        return false;
    }

}
```