class Product
{
    private string _name;
    private string _ID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string ID, double pricePerUnit)
    {
        _name = name;
        _ID = ID;
        _pricePerUnit = pricePerUnit;
    }

    public double GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
       return _name; 
    }

    public string GetID()
    {
        return _ID;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}