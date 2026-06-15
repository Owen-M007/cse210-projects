class Program
{
    public static void DisplayPersonInfo(Person person)
    {
        // if (person is Doctor doctor)
        //     Console.WriteLine(doctor.GetDoctorInfo());
        // else if (person is Policeman policeman)
        //     Console.WriteLine(policeman.GetPolicemanInfo());
        // else
        Console.WriteLine(person.GetPersonInfo());
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("helloz");

        // Person myPerson = new Person("Bob", "Roberts", 57, 195);
        // Console.WriteLine(myPerson.GetPersonInfo());

        Policeman myPoliceman = new Policeman("pistol", "Paul", "Blart", 32, 176);
        // Console.WriteLine(myPoliceman.GetPolicemanInfo());

        Doctor myDoctor = new Doctor("MD", "John", "Payne", 43, 187);
        // Console.WriteLine(myDoctor.GetDoctorInfo());

        
        myDoctor.ChangeWeight(10);
        myPoliceman.ChangeWeight(-11);

        // Console.WriteLine(myPoliceman.GetPolicemanInfo());
        // Console.WriteLine(myDoctor.GetDoctorInfo());



        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceman);

        foreach (Person person in myPeople)
        {
            // Console.WriteLine(person.GetPersonInfo());
            DisplayPersonInfo(person);
            Console.WriteLine(person.GetSalary());
        }
    }
}