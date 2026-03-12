namespace projekt_hagrid.Models;

public class Student
{
    public string Name { get; set; }
    public int Alter { get; set; }
    public List<Bewertung> Bewertungen { get; set; } = new List<Bewertung>();

    public Student(string name, int alter)
    {
        Name = name;
        Alter = alter;
    }
    public void StatistikAnzeigen()
{
    if (Bewertungen.Count == 0)
    {
        Console.WriteLine($"Für {Name} sind keine Bewertungen vorhanden.");
        return;
    }

    int anzahlBestanden = Bewertungen.Count(b => b.BestandenPruefen());
    int anzahlDurchgefallen = Bewertungen.Count - anzahlBestanden;
    double durchschnitt = Bewertungen.Average(b => b.NoteBerechnen());
    double besteNote = Bewertungen.Min(b => b.NoteBerechnen());

    Console.WriteLine($"\n=== Statistik für {Name} ===");
    Console.WriteLine($"Anzahl Bewertungen: {Bewertungen.Count}");
    Console.WriteLine($"Bestanden: {anzahlBestanden}");
    Console.WriteLine($"Durchgefallen: {anzahlDurchgefallen}");
    Console.WriteLine($"Durchschnittsnote: {durchschnitt:F2}");
    Console.WriteLine($"Beste Note: {besteNote:F1}");
}
}