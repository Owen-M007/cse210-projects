using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Billy Bart");
        customer1.SetAddress("123 Stinky Street", "StinkTown", "Smelly", "Stanky");

        Product product1 = new Product("bread", "ID-4321", 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 1);

        order1.DisplayOrderPrice();
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
    }
}