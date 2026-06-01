class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("helloz");

        Person myPerson = new Person("Bob", "Roberts", 57, 195);
        Console.WriteLine(myPerson.GetPersonInfo());
    }
}