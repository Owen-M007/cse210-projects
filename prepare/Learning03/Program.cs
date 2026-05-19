using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(f1.GetTop());
        f1.SetBottom(f1.GetBottom());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        f2.SetTop(f2.GetTop());
        f2.SetBottom(f2.GetBottom());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(6, 8);
        f3.SetTop(f3.GetTop());
        f3.SetBottom(f3.GetBottom());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());



        Fraction f4 = new Fraction();
        Random rand = new Random();
        int iterator = 1;

        while (iterator < 21)
        {
            f4.SetTop(rand.Next(1,10));
            f4.SetBottom(rand.Next(1,10));
            Console.WriteLine($"Fraction {iterator}: string: {f4.GetFractionString()} number: {f4.GetDecimalValue()}");
            iterator += 1;
        }
    }
}