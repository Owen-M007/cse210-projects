class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int CalculateOrderTotal()
    {
        
    }

    private int CalculateShippingCost()
    {
        
    }
}