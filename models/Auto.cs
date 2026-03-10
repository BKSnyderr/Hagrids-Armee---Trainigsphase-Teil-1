namespace projekt_hagrid.models;

public class Auto
{
    public string Marke { get; set; }
    public int Baujahr { get; set; }

    public Auto(string marke, int baujahr)
    {
        Marke = marke;
        Baujahr = baujahr;
    }

    public void Fahren(int geschwindigkeit)
    {
        Console.WriteLine($"{Marke} fährt mit {geschwindigkeit} km/h.");
    }
}