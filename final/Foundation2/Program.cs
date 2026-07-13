using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Billy Bart");
        customer1.SetAddress("123 Stinky Street", "StinkTown", "Smelly", "Stanky");
        customer1.DisplayCustomerInfo();
    }
}