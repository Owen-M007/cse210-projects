class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        SetWeight(weight);
    }

    public string GetPersonInfo()
    {
        return $"Name: {_firstName} {_lastName}, Age: {_age}, Weight: {_weight}";
    }

    public void ChangeWeight(int update)
    {
        SetWeight(_weight += update);
    }

     public void SetWeight(int weight)
    {
        _weight = weight;
        if (weight < 0 || weight > 600)
        {
            _weight = 0;
            Console.WriteLine("Nuh uh, incorrect weight.");
        }
    }
    
    public void SetAge(int age)
    {
        _age = age;
        if (age < 0 || age > 225)
        {
            _age = 0;
            Console.WriteLine("Nuh uh, incorrect age.");
        }
    }
}