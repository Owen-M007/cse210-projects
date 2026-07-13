class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
        _address = new Address();
    }

    public void SetAddress(string street, string city, string stateOrProvince, string country)
    {
        _address.SetStreet(street);
        _address.SetCity(city);
        _address.SetStateOrProvince(stateOrProvince);
        _address.SetCountry(country);
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.FullAddress();
    }

    public bool LiveInUSA()
    {
        return _address.IsUSA();
    }

    // public void DisplayCustomerInfo()
    // {
    //     Console.WriteLine($"Name: {_name}");
    //     Console.WriteLine("Address:");
    //     Console.WriteLine();
    //     Console.WriteLine($"Lives in the USA?: {_address.IsUSA()}");
    //     Console.WriteLine("");
    // }
}