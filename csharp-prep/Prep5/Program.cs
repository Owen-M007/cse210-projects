using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        
        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        number *= number;
        return number;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int currentYear = 2026;
        int currentAge = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{name}, you will turn {currentAge} this year.");
    }
}