namespace projekt_hagrid.Models;

public class Kurs
{
    public string _titel { get; set; }
    public int _maxTeilnehmer { get; set; }
    public List<Student> _teilnehmer { get; set; } = new List<Student>();
    public KursStatus _status { get; set; } = KursStatus.Offen;

    public Kurs(string titel, int maxTeilnehmer, KursStatus status)
    {
        _titel = titel;
        _maxTeilnehmer = maxTeilnehmer;
        _status = status;
    }

    public void ZeigeTeilnehmer()
    {
        Console.WriteLine($"Kurs: {_titel}");
        Console.WriteLine("Teilnehmer:");
        foreach (var student in _teilnehmer)
        {
            Console.WriteLine($"- {student.Name}, Alter: {student.Alter}");
        }
    }

    public void MaxTeilnehmer()
    {
        Console.WriteLine($"Maximale Teilnehmerzahl für {_titel}: {_maxTeilnehmer}");
        if (_teilnehmer.Count >= _maxTeilnehmer)
        {
            Console.WriteLine("Der Kurs ist voll.");
        }
        else
        {
            Console.WriteLine($"Es sind noch {_maxTeilnehmer - _teilnehmer.Count} Plätze frei.");
        }
    }
    public void StatistikAnzeigen()
{
    var alleBewertungen = _teilnehmer.SelectMany(t => t.Bewertungen).ToList();

    if (alleBewertungen.Count == 0)
    {
        Console.WriteLine($"Im Kurs {_titel} sind keine Bewertungen vorhanden.");
        return;
    }

    int bestanden = alleBewertungen.Count(b => b.BestandenPruefen());
    int durchgefallen = alleBewertungen.Count - bestanden;
    double durchschnitt = alleBewertungen.Average(b => b.NoteBerechnen());
    double besteNote = alleBewertungen.Min(b => b.NoteBerechnen());

    Console.WriteLine($"\n=== Gesamtstatistik für {_titel} ===");
    Console.WriteLine($"Teilnehmer: {_teilnehmer.Count}");
    Console.WriteLine($"Bewertungen: {alleBewertungen.Count}");
    Console.WriteLine($"Bestanden: {bestanden}");
    Console.WriteLine($"Durchgefallen: {durchgefallen}");
    Console.WriteLine($"Durchschnittsnote: {durchschnitt:F2}");
    Console.WriteLine($"Beste Note im Kurs: {besteNote:F1}");
}
}