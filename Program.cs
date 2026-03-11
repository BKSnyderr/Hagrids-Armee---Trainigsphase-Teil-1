using projekt_hagrid.models;
using System;
using System.Collections.Generic;
using System.Linq;

// ==={ AUFGABE 1 }===

// Aufgabe 1.1

Console.WriteLine("==={ AUFGABE 1.1 }===");
Console.WriteLine();

string name = "John";

Console.WriteLine(name);

int age = 30;

Console.WriteLine(age);

string city = "New York";

Console.WriteLine(city);

Console.WriteLine("--------------------");

// Aufgabe 1.2

Console.WriteLine("==={ AUFGABE 1.2 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie Ihren Namen ein:");

string userName = Console.ReadLine();

Console.WriteLine("Hallo, " + userName);

Console.WriteLine("--------------------");

// Aufgabe 1.3

Console.WriteLine("==={ AUFGABE 1.3 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie Ihr Alter ein:");

string userAge = Console.ReadLine();

Console.WriteLine("Du bist " + userAge + " Jahre alt.");

Console.WriteLine("--------------------");

// Aufgabe 1.4

Console.WriteLine("==={ AUFGABE 1.4 }===");
Console.WriteLine();

int a = 10;
int b = 20;
int sum = a + b;
int difference = a - b;
int product = a * b;

Console.WriteLine("Summe: " + sum);
Console.WriteLine("Differenz: " + difference);
Console.WriteLine("Produkt: " + product);

Console.WriteLine("--------------------");

// Aufgabe 1.5

Console.WriteLine("==={ AUFGABE 1.5 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie die erste Zahl ein:");

string firstNumberInput = Console.ReadLine();

Console.WriteLine("Geben Sie die zweite Zahl ein:");

string secondNumberInput = Console.ReadLine();
int firstNumber = int.Parse(firstNumberInput);
int secondNumber = int.Parse(secondNumberInput);

Console.WriteLine("Die Summe ist: " + (firstNumber + secondNumber));

Console.WriteLine("--------------------");

// Aufgabe 1.6

Console.WriteLine("==={ AUFGABE 1.6 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Zahl ein:");

string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);
int square = number * number;

Console.WriteLine("Das Quadrat der Zahl ist: " + square);

Console.WriteLine("--------------------");


// ==={ AUFGABE 2 }===

// Aufgabe 2.1

Console.WriteLine("==={ AUFGABE 2.1 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Zahl ein:");

string numberInput2 = Console.ReadLine();
int number2 = int.Parse(numberInput2);
if (number2 > 10)
{
    Console.WriteLine("Groß");
}
else
{
    Console.WriteLine("Klein");
}

Console.WriteLine("--------------------");

// Aufgabe 2.2

Console.WriteLine("==={ AUFGABE 2.2 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Punktzahl zwischen 0 und 100 ein:");

string scoreInput = Console.ReadLine();
int score = int.Parse(scoreInput);
if (score >= 50)
{
    Console.WriteLine("Bestanden");
}
else
{
    Console.WriteLine("Nicht bestanden");
}

Console.WriteLine("--------------------");

// Aufgabe 2.3

Console.WriteLine("==={ AUFGABE 2.3 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Punktzahl zwischen 0 und 100 ein:");

string scoreInput2 = Console.ReadLine();
int score2 = int.Parse(scoreInput2);
if (score2 >= 90)
{
    Console.WriteLine("Note 1");
}
else if (score2 >= 80)
{
    Console.WriteLine("Note 2");
}
else if (score2 >= 70)
{
    Console.WriteLine("Note 3");
}
else if (score2 >= 60)
{
    Console.WriteLine("Note 4");
}
else
{
    Console.WriteLine("Nicht bestanden");
}

Console.WriteLine("--------------------");

// Aufgabe 2.4

Console.WriteLine("==={ AUFGABE 2.4 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie ihr Alter ein:");

string ageInput = Console.ReadLine();
int age2 = int.Parse(ageInput);
if (age2 >= 18)
{
    Console.WriteLine("Volljährig");
}
else
{
    Console.WriteLine("Minderjährig");
}

Console.WriteLine("--------------------");

// Aufgabe 2.5

Console.WriteLine("==={ AUFGABE 2.5 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Zahl ein:");

string numberInput3 = Console.ReadLine();
int number3 = int.Parse(numberInput3);
if (number3 % 2 == 0)
{
    Console.WriteLine("Gerade");
}
else
{
    Console.WriteLine("Ungerade");
}

Console.WriteLine("--------------------");

// Aufgabe 2.6

Console.WriteLine("==={ AUFGABE 2.6 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie die erste Zahl ein:");

string firstNumberInput2 = Console.ReadLine();

Console.WriteLine("Geben Sie die zweite Zahl ein:");

string secondNumberInput2 = Console.ReadLine();
int firstNumber2 = int.Parse(firstNumberInput2);
int secondNumber2 = int.Parse(secondNumberInput2);
if (firstNumber2 > secondNumber2)
{
    Console.WriteLine($"{firstNumber2} ist größer als {secondNumber2}");
}
else if (secondNumber2 > firstNumber2)
{
    Console.WriteLine($"{secondNumber2} ist größer als {firstNumber2}");
}
else
{
    Console.WriteLine("Beide Zahlen sind gleich.");
}

Console.WriteLine("--------------------");

// ==={ AUFGABE 3 }===

// Aufgabe 3.1

Console.WriteLine("==={ AUFGABE 3.1 }===");
Console.WriteLine();

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

Console.WriteLine("Die Zahlen sind:");

foreach (int n in numbers)
{
    Console.Write(n + " ");
}
Console.WriteLine();
Console.WriteLine("--------------------");

// Aufgabe 3.2

Console.WriteLine("==={ AUFGABE 3.2 }===");
Console.WriteLine();

int[] numbers2 = Enumerable.Range(1, 50).ToArray();

Console.WriteLine("Die geraden Zahlen von 1 bis 50 sind:");

foreach (int n in numbers2)
{
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
    }
}
Console.WriteLine();

Console.WriteLine("--------------------");

// Aufgabe 3.3

Console.WriteLine("==={ AUFGABE 3.3 }===");
Console.WriteLine();

int[] numbers3 = Enumerable.Range(1, 100).ToArray();
int sum2 = numbers3.Sum();

Console.WriteLine("Die Summe der Zahlen von 1 bis 100 ist: " + sum2);
Console.WriteLine("--------------------");

// Aufgabe 3.4

Console.WriteLine("==={ AUFGABE 3.4 }===");
Console.WriteLine();
Console.WriteLine("Geben Sie eine Zahl ein:");

string numberInput4 = Console.ReadLine();
int number4 = int.Parse(numberInput4);
int[] numbers4 = Enumerable.Range(1, number4).ToArray();

Console.WriteLine($"Die Zahlen von 1 bis {number4} sind:");

foreach (int n in numbers4)
{
    Console.Write(n + " ");
}
Console.WriteLine();
Console.WriteLine("--------------------");

// Aufgabe 3.5

Console.WriteLine("==={ AUFGABE 3.5 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Zahl ein:");

string numberInput5 = Console.ReadLine();
int number5 = int.Parse(numberInput5);
for (int i = 1; i <= number5; i++)
{
    for (int j = 1; j <= number5; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("--------------------");

// Aufgabe 3.6

Console.WriteLine("==={ AUFGABE 3.6 }===");
Console.WriteLine();

int[] numbers6 = Enumerable.Range(1, 10).ToArray();

Console.WriteLine("Die Zahlen von 1 bis 10 in umgekehrter Reihenfolge sind:");

for (int i = numbers6.Length - 1; i >= 0; i--)
{
    Console.Write(numbers6[i] + " ");
}
Console.WriteLine();

Console.WriteLine("--------------------");

// ==={ AUFGABE 4 }===

// Aufgabe 4.1

Console.WriteLine("==={ AUFGABE 4.1 }===");
Console.WriteLine();

string SagHallo()
{
    return "Hallo!";
}
Console.WriteLine(SagHallo());

Console.WriteLine("--------------------");

// Aufgabe 4.2

Console.WriteLine("==={ AUFGABE 4.2 }===");
Console.WriteLine();

int Addiere(int a, int b)
{
    return a + b;
}
Console.WriteLine(Addiere(5, 10));

Console.WriteLine("--------------------");

// Aufgabe 4.3

Console.WriteLine("==={ AUFGABE 4.3 }===");
Console.WriteLine();

string IstGerade(int zahl)
{
    if (zahl % 2 == 0)
    {
        return "Gerade";
    }
    else
    {
        return "Ungerade";
    }
}
Console.WriteLine(IstGerade(4));
Console.WriteLine(IstGerade(7));

Console.WriteLine("--------------------");

// Aufgabe 4.4

Console.WriteLine("==={ AUFGABE 4.4 }===");
Console.WriteLine();

int Quadrat(int zahl)
{
    return zahl * zahl;
}
Console.WriteLine(Quadrat(5));

Console.WriteLine("--------------------");

// Aufgabe 4.5

Console.WriteLine("==={ AUFGABE 4.5 }===");
Console.WriteLine();

int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
Console.WriteLine($"Max(5, 10): {Max(5, 10)}");

Console.WriteLine("--------------------");

// Aufgabe 4.6

Console.WriteLine("==={ AUFGABE 4.6 }===");
Console.WriteLine();

string NoteBerechnen(int punktzahl)
{
    if (punktzahl >= 90)
    {
        return "Note 1";
    }
    else if (punktzahl >= 80)
    {
        return "Note 2";
    }
    else if (punktzahl >= 70)
    {
        return "Note 3";
    }
    else if (punktzahl >= 60)
    {
        return "Note 4";
    }
    else
    {
        return "Nicht bestanden";
    }
}
Console.WriteLine("Gib deine Punktzahl ein:");

string punktzahlInput = Console.ReadLine();
int punktzahl = int.Parse(punktzahlInput);

Console.WriteLine(NoteBerechnen(punktzahl));

Console.WriteLine("--------------------");

// ==={ AUFGABE 5 }===

// Aufgabe 5.2

Console.WriteLine("==={ AUFGABE 5.2 }===");
Console.WriteLine();

Auto polo = new Auto("VW", 2010);

Console.WriteLine($"Auto: {polo.Marke}, Baujahr: {polo.Baujahr}");

Console.WriteLine("--------------------");
// Aufgabe 5.3

Console.WriteLine("==={ AUFGABE 5.3 }===");
Console.WriteLine();

Auto benz = new Auto("Mercedes-Benz", 2015);

Console.WriteLine($"Auto: {benz.Marke}, Baujahr: {benz.Baujahr}");

Console.WriteLine("--------------------");

// Aufgabe 5.5

Console.WriteLine("==={ AUFGABE 5.5 }===");
Console.WriteLine();

polo.Fahren(80);
benz.Fahren(120);

Console.WriteLine("--------------------");

// Aufgabe 5.6

Console.WriteLine("==={ AUFGABE 5.6 }===");
Console.WriteLine();

List<Auto> autos = new List<Auto>
{
    new Auto("VW Golf", 2012),
    new Auto("Audi A4", 2018),
    new Auto("BMW 3er", 2020),
    new Auto("Mercedes-Benz C-Klasse", 2019),
    new Auto("Ford Focus", 2014)
};
Console.WriteLine("Autos in der Liste:");

foreach (Auto auto in autos)
{
    Console.WriteLine($"{auto.Marke}, Baujahr: {auto.Baujahr}");
}

Console.WriteLine("--------------------");

// ==={ AUFGABE 6 }===

// Aufgabe 6.3

Console.WriteLine("==={ AUFGABE 6.3 }===");
Console.WriteLine();

Auto bmw = new Auto("BMW", 2021);

Console.WriteLine($"Auto: {bmw.Marke}, Baujahr: {bmw.Baujahr}");

Console.WriteLine("--------------------");

// Aufgabe 6.4

Console.WriteLine("==={ AUFGABE 6.4 }===");
Console.WriteLine();

Console.WriteLine($"Auto: {polo.Marke}, Baujahr: {polo.Baujahr}");
Console.WriteLine($"Auto: {benz.Marke}, Baujahr: {benz.Baujahr}");
Console.WriteLine($"Auto: {bmw.Marke}, Baujahr: {bmw.Baujahr}");

Console.WriteLine("--------------------");

// Aufgabe 6.6

Console.WriteLine("==={ AUFGABE 6.6 }===");
Console.WriteLine();

polo.Info();
benz.Info();
bmw.Info();

Console.WriteLine("--------------------");

// ==={ AUFGABE 7 }===

// Aufgabe 7.3

List<Student> studenten = new List<Student>{};

// Aufgabe 7.4

studenten.Add(new Student("Alice", 20));
studenten.Add(new Student("Bob", 22));
studenten.Add(new Student("Charlie", 19));
studenten.Add(new Student("Diana", 21));
studenten.Add(new Student("Eve", 23));

// // Aufgabe 7.5

Console.WriteLine("==={ AUFGABE 7.5 }===");
Console.WriteLine();

Console.WriteLine("Studenten in der Liste:");

foreach (Student student in studenten)
{
    Console.WriteLine($"Name: {student.Name}, Alter: {student.Alter}");
}

Console.WriteLine("---------------------");

// // Aufgabe 7.6

Console.WriteLine("==={ AUFGABE 7.6 }===");
Console.WriteLine();

Console.WriteLine($"Es gibt {studenten.Count} Studenten in der Liste.");

Console.WriteLine("---------------------");

// ==={ AUFGABE 8 }===

// Aufgabe 8.1

Console.WriteLine("==={ AUFGABE 8.1 }===");
Console.WriteLine();

foreach (Student student in studenten)
{
    if (student.Alter > 20)
    {
        Console.WriteLine($"Name: {student.Name}, Alter: {student.Alter}");
    }
}

Console.WriteLine("---------------------");

// Aufgabe 8.2

Console.WriteLine("==={ AUFGABE 8.2 }===");
Console.WriteLine();

bool gefunden = false;

foreach (Student student in studenten)
{
    if (student.Alter < 18)
    {
        Console.WriteLine($"Name: {student.Name}, Alter: {student.Alter}");
        gefunden = true;
    }
    
}
if (!gefunden)
{
    Console.WriteLine("Kein Student unter 18 Jahren gefunden.");
}

Console.WriteLine("---------------------");

// Aufgabe 8.3

Console.WriteLine("==={ AUFGABE 8.3 }===");
Console.WriteLine();

int anzahlStudentenUeber25 = 0;

foreach (Student student in studenten)
{
    if(student.Alter > 25)
    {
        anzahlStudentenUeber25++;
    }   
}
Console.WriteLine($"Anzahl der Studenten über 25 Jahren: {anzahlStudentenUeber25}");

Console.WriteLine("---------------------");

// Aufgabe 8.4

Console.WriteLine("==={ AUFGABE 8.4 }===");
Console.WriteLine();

var sortierteStudenten = studenten.OrderByDescending(s => s.Alter);

foreach (Student student in sortierteStudenten)
{
    Console.WriteLine($"Name: {student.Name}, Alter: {student.Alter}");
}

Console.WriteLine("---------------------");

// Aufgabe 8.5

Console.WriteLine("==={ AUFGABE 8.5 }===");
Console.WriteLine();

foreach (Student student in studenten)
{
    Console.WriteLine($"Name: {student.Name}");
}

Console.WriteLine("---------------------");

// Aufgabe 8.6

Console.WriteLine("==={ AUFGABE 8.6 }===");
Console.WriteLine();

var aeltesteStudent = 0;

foreach (Student student in studenten)
{
    if(student.Alter > aeltesteStudent)
    {
        aeltesteStudent = student.Alter;
    }
}

Console.WriteLine($"Das älteste Student ist {aeltesteStudent} Jahre alt.");
Console.WriteLine("---------------------");

// ==={ AUFGABE 9 }===

// Aufgabe 9.1

Console.WriteLine("==={ AUFGABE 9.1 }===");
Console.WriteLine();

var avgAlter = studenten.Average(s => s.Alter);
Console.WriteLine($"Durchschnittliches Alter der Studenten: {avgAlter}");

Console.WriteLine("---------------------");

// Aufgabe 9.2

Console.WriteLine("==={ AUFGABE 9.2 }===");
Console.WriteLine();

var aeltesteStudent2 = studenten.Max(s => s.Alter);
Console.WriteLine($"Das älteste Student ist {aeltesteStudent2} Jahre alt.");

Console.WriteLine("---------------------");

// Aufgabe 9.3

Console.WriteLine("==={ AUFGABE 9.3 }===");
Console.WriteLine();

var sortierteStudenten2 = studenten.OrderBy(s => s.Name);
foreach (Student student in sortierteStudenten2)
{
    Console.WriteLine($"Name: {student.Name}, Alter: {student.Alter}");
}
Console.WriteLine("---------------------");

// Aufgabe 9.4

Console.WriteLine("==={ AUFGABE 9.4 }===");
Console.WriteLine();

var studentenUeber20 = studenten.Where(s => s.Alter > 20);
foreach (Student student in studentenUeber20)
{
    Console.WriteLine($"Name: {student.Name}, Alter: {student.Alter}");
}
Console.WriteLine("---------------------");

// Aufgabe 9.5

Console.WriteLine("==={ AUFGABE 9.5 }===");
Console.WriteLine();

var studentenAnzahl = studenten.Count();
Console.WriteLine($"Anzahl der Studenten: {studentenAnzahl}");

Console.WriteLine("---------------------");

// Aufgabe 9.6

Console.WriteLine("==={ AUFGABE 9.6 }===");
Console.WriteLine();

var studentenNamen = studenten.Select(s => s.Name);
foreach (string Name in studentenNamen)
{
    Console.WriteLine($"Name: {Name}");
}

Console.WriteLine("---------------------");

// ==={ AUFGABE 10 }===

// Aufgabe 10.1 + 10.2

Console.WriteLine("==={ AUFGABE 10.1 }===");
Console.WriteLine();

double Division(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
        return double.NaN; // Rückgabe von NaN (Not a Number) bei Division durch Null
    }
    return a / b;
}

Console.WriteLine(Division(10, 2));
Console.WriteLine(Division(10, 0));

Console.WriteLine("---------------------");

// Aufgabe 10.3 + 10.4 + 10.5 + 10.6

Console.WriteLine("==={ AUFGABE 10.3 }===");
Console.WriteLine();

Console.WriteLine("Geben Sie eine Zahl ein:");

string eingabeZahl = Console.ReadLine();
int zahl = int.TryParse(eingabeZahl, out int result) ? result : 0;
if(zahl == 0)
{
    Console.WriteLine("Ungültige Eingabe. Keine Zahl.");
}
else
{
    Console.WriteLine($"Die eingegebene Zahl ist: {zahl}");
}

Console.WriteLine("---------------------");
