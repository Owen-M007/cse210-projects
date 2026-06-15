class Policeman : Person
{
    private string _weapons;

    public Policeman(string weapons, string firstName, string lastName, int age, int weight) : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string GetPersonInfo()
    {
        return $"Weapons: {_weapons}, {base.GetPersonInfo()}";
    }

    public override double GetSalary()
    {
        return 123000.00;
    }

}