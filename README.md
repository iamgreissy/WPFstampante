# WPFstampante
```C#
public class Stampante
{
    public int C { get; private set; }
    public int M { get; private set; }
    public int Y { get; private set; }
    public int B { get; private set; }
    public int Fogli { get; private set; }

    // COSTRUTTORE
    public Stampante()
    {
        C = M = Y = B = 100; // assumendo che il valore predefinito sia 100 per ogni colore
        Fogli = 200;
    }

    // metodo
    public bool Stampa(Pagina p)
    {
        if (Fogli > 0 && C >= p.C && M >= p.M && Y >= p.Y && B >= p.B)
        {
            C -= p.C;
            M -= p.M;
            Y -= p.Y;
            B -= p.B;
            Fogli--;

            return true;
        }
        return false;
    }

    public int Inch(string colore)
    {
        // Supponendo che si voglia ottenere il livello di inchiostro del colore specificato
        switch (colore.ToUpper())
        {
            case "C":
                return C;
            case "M":
                return M;
            case "Y":
                return Y;
            case "B":
                return B;
            default:
                throw new ArgumentException("Colore specificato non valido.");
        }
    }
}
```
