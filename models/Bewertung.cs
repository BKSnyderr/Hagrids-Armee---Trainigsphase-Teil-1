namespace projekt_hagrid.Models;

public class Bewertung
{
    public int Punkte { get; set; }

    public Bewertung(int punkte)
    {
        Punkte = punkte;
    }

    public double NoteBerechnen()
    {
        if (Punkte >= 90) return 1.0;
        if (Punkte >= 80) return 2.0;
        if (Punkte >= 70) return 3.0;
        if (Punkte >= 60) return 4.0;
        return 5.0;
    }

    public bool BestandenPruefen()
    {
        return NoteBerechnen() <= 4.0;
    }

    public void Anzeige()
    {
        Console.WriteLine($"Punkte: {Punkte}, Note: {NoteBerechnen()}, Bestanden: {BestandenPruefen()}");
    }
}
