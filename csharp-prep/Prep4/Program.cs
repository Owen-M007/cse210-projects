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

        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }

    }
}