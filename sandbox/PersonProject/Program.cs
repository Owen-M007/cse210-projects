class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("helloz");

        Person myPerson = new Person("Bob", "Roberts", 57, 195);
        Console.WriteLine(myPerson.GetPersonInfo());

        Policeman myPoliceman = new Policeman("pistol", "Paul", "Blart", 32, 176);
        Console.WriteLine(myPoliceman.GetPolicemanInfo());

        Doctor myDoctor = new Doctor("MD", "John", "Payne", 43, 187);
        Console.WriteLine(myDoctor.GetDoctorInfo());

        
        myDoctor.ChangeWeight(10);
        myPoliceman.ChangeWeight(-11);

        Console.WriteLine(myPoliceman.GetPolicemanInfo());
        Console.WriteLine(myDoctor.GetDoctorInfo());
        
    }
}