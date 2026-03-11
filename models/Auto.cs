namespace projekt_hagrid.Models;

public class Auto
{
    public string Marke { get; set; }
    public int Baujahr { get; set; }

    public Auto(string marke, int baujahr)
    {
        Marke = marke;
        Baujahr = baujahr;
    }

    public void Info()
    {
        Console.WriteLine($"Auto: {Marke}, Baujahr: {Baujahr}");
    }

    public void Fahren(int geschwindigkeit)
    {
        Console.WriteLine($"{Marke} fährt mit {geschwindigkeit} km/h.");
    }
}