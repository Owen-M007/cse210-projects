using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> nums = new List<int>();

        int num;

        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            nums.Add(num);
        } while (num != 0);

        int sum = 0;
        foreach (int i in nums)
        {
            sum += i;
        }

        double avg = nums.Where(i => i != 0).Average();

        int max = nums.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");

    }
}