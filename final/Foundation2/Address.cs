class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address()
    {
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    
    public string FullAddress()
    {
        return $"""
        {_street}
        {_city}
        {_stateOrProvince}, {_country}
        """;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}