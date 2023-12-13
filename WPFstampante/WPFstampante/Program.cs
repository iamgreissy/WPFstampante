using System;

public class Pagina
{
    public int C { get; }
    public int M { get; }
    public int Y { get; }
    public int B { get; }

    public Pagina(int c, int m, int y, int b)
    {
        if (IsValidColoreValue(c) && IsValidColoreValue(m) && IsValidColoreValue(y) && IsValidColoreValue(b))
        {
            C = c;
            M = m;
            Y = y;
            B = b;
        }
        else
        {
            throw new ArgumentException("Valore del colore non valido. Deve essere compreso tra 0 e 100.");
        }
    }

    private bool IsValidColoreValue(int value)
    {
        return value >= 0 && value <= 100;
    }
}

public class Stampante
{
    public int C { get; private set; }
    public int M { get; private set; }
    public int Y { get; private set; }
    public int B { get; private set; }
    public int Fogli { get; private set; }

    public Stampante()
    {
        C = M = Y = B = 100; // assumendo che il valore predefinito sia 100 per ogni colore
        Fogli = 200;
    }

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

    public int StatoInchiostro(Colore colore)
    {
        switch (colore)
        {
            case Colore.C:
                return C;
            case Colore.M:
                return M;
            case Colore.Y:
                return Y;
            case Colore.B:
                return B;
            default:
                throw new ArgumentException("Colore non valido.");
        }
    }

    public int StatoCarta()
    {
        return Fogli;
    }

    public void SostituisciColore(Colore colore)
    {
        switch (colore)
        {
            case Colore.C:
                C = 100;
                break;
            case Colore.M:
                M = 100;
                break;
            case Colore.Y:
                Y = 100;
                break;
            case Colore.B:
                B = 100;
                break;
            default:
                throw new ArgumentException("Colore non valido.");
        }
    }

    public void AggiungiCarta(int qta)
    {
        if (qta > 0)
        {
            Fogli = Math.Min(Fogli + qta, 200);
        }
        else
        {
            throw new ArgumentException("La quantità di carta deve essere maggiore di zero.");
        }
    }
}

public enum Colore
{
    C,
    M,
    Y,
    B
}
