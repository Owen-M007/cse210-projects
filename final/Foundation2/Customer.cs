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

    public bool LiveInUSA()
    {
        return _address.IsUSA();
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Address:");
        Console.WriteLine(_address.FullAddress());
        Console.WriteLine($"Lives in the USA?: {_address.IsUSA()}"); // this will be removed when all is finished
        Console.WriteLine("");
    }
}