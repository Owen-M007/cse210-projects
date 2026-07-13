class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product, int quantity)
    {
        product.SetQuantity(quantity);
        _products.Add(product);
    }

    public int CalculateOrderTotal()
    {
        int subTotal = 0;
        foreach (Product product in _products)
        {
            subTotal += product.GetTotalPrice();
        }
        int total = subTotal + CalculateShippingCost();
        return total;
    }

    private int CalculateShippingCost()
    {
        int shippingCost = 5;
        if (!_customer.LiveInUSA())
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("| Packing Label |");
        foreach (Product product in _products)
        {
            Console.WriteLine($"> {product.GetName()} (ID: {product.GetID()})");
        }
        Console.WriteLine("");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("| Shipping Label |");
        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.WriteLine("Address:");
        Console.WriteLine(_customer.GetAddress());
        Console.WriteLine("");
    }

    public void DisplayOrderPrice()
    {
        Console.WriteLine($"Order total: ${CalculateOrderTotal()}");
        Console.WriteLine("");
    }
}