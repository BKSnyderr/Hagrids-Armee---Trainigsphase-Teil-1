// ==={ AUFGABE 1 }===

// Aufgabe 1.1

string name = "John";
Console.WriteLine(name);
int age = 30;
Console.WriteLine(age);
string city = "New York";
Console.WriteLine(city);
Console.WriteLine("--------------------");

// Aufgabe 1.2

Console.WriteLine("Geben Sie Ihren Namen ein:");
string userName = Console.ReadLine();
Console.WriteLine("Hallo, " + userName);
Console.WriteLine("--------------------");

// Aufgabe 1.3

Console.WriteLine("Geben Sie Ihr Alter ein:");
string userAge = Console.ReadLine();
Console.WriteLine("Du bist " + userAge + " Jahre alt.");
Console.WriteLine("--------------------");

// Aufgabe 1.4

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

Console.WriteLine("Geben Sie die erste Zahl ein:");
string firstNumberInput = Console.ReadLine();
Console.WriteLine("Geben Sie die zweite Zahl ein:");
string secondNumberInput = Console.ReadLine();
int firstNumber = int.Parse(firstNumberInput);
int secondNumber = int.Parse(secondNumberInput);
Console.WriteLine("Die Summe ist: " + (firstNumber + secondNumber));
Console.WriteLine("--------------------");

// Aufgabe 1.6

Console.WriteLine("Geben Sie eine Zahl ein:");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);
int square = number * number;
Console.WriteLine("Das Quadrat der Zahl ist: " + square);


// ==={ AUFGABE 2 }===

// Aufgabe 2.1

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

Console.WriteLine("Geben Sie eine Punktzahl ein:");
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

Console.WriteLine("Geben Sie eine Punktzahl ein:");
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