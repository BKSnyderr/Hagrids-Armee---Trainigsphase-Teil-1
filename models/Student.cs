namespace projekt_hagrid.Models;

public class Student
{
    public string Name { get; set; }
    public int Alter { get; set; }

    public Student(string name, int alter)
    {
        Name = name;
        Alter = alter;
    }
}