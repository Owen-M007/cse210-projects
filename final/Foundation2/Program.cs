using System;

class Program
{
    static void Main(string[] args)
    {        
        // order 1
        Customer customer1 = new Customer("Billy Bart");
        customer1.SetAddress("650 S 1st W", "Rexburg", "Idaho", "USA");

        Product product1 = new Product("BIC mechanical pencil", "MP-12345", 1.49);
        Product product2 = new Product("ThisThangLoudBruh bluetooth speaker", "BT-32123", 79.99);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 4);
        order1.AddProduct(product2, 1);

        Console.WriteLine("--- order 1 ---");
        order1.DisplayOrderPrice();
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();

        // order 2
        Customer customer2 = new Customer("Wilson Williams");
        customer2.SetAddress("4 Abbeyfield WV16 4RU", "Bridgenorth", "West Midlands", "England");

        Product product3 = new Product("BIC traditional pencil", "TP-54321", 0.99);
        Product product4 = new Product("Smarty Pants", "IQ-99999", 39.99);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3, 3);
        order2.AddProduct(product4, 2);

        Console.WriteLine("--- order 2 ---");
        order2.DisplayOrderPrice();
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
    }
}