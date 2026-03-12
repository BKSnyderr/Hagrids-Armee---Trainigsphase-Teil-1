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
}