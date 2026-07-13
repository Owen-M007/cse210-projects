class Product
{
    private string _name;
    private int _ID;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int ID, int pricePerUnit, int quantity)
    {
        _name = name;
        _ID = ID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
       return _name; 
    }

    public int GetID()
    {
        return _ID;
    }

    public int GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}