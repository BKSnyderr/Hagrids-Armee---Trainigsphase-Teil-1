namespace projekt_hagrid.Models;

public class Kurs
{
    public string Titel { get; set; }
    public int MaxTeilnehmer { get; set; }
    public List<Student> Teilnehmer { get; set; }

    public Kurs(string titel, int maxTeilnehmer)
    {
        Titel = titel;
        MaxTeilnehmer = maxTeilnehmer;
        Teilnehmer = new List<Student>();
    }

    public void zeigeTeilnehmer()
    {
        Console.WriteLine($"Kurs: {Titel}");
        Console.WriteLine("Teilnehmer:");
        foreach (var student in Teilnehmer)
        {
            Console.WriteLine($"- {student.Name}, Alter: {student.Alter}");
        }
    }

    public void maxTeilnehmer()
    {
        Console.WriteLine($"Maximale Teilnehmerzahl für {Titel}: {MaxTeilnehmer}");
        if (Teilnehmer.Count >= MaxTeilnehmer)
        {
            Console.WriteLine("Der Kurs ist voll.");
        }
        else
        {
            Console.WriteLine($"Es sind noch {MaxTeilnehmer - Teilnehmer.Count} Plätze frei.");
        }
    }
}