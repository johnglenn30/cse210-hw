using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Product product1 = new Product();
        product1.ProductName("Safeguard");
        product1.ProductId(00001);
        product1.Price(7);
        product1.Quantity(12);

        Product product2 = new Product();
        product2.ProductName("Olive Oil");
        product2.ProductId(00212);
        product2.Price(100);
        product2.Quantity(12);

        Address address= new Address();
        address.SetStreet("123 MC");
        address.SetCity("General Santos");
        address.SetState("Socksargen");
        address.SetCountry("Philippines");

        Address address1= new Address();
        address1.SetStreet("Kennon 1323");
        address1.SetCity("Baguio");
        address1.SetState("Benguet");
        address1.SetCountry("Philippines");

        

        Customer customer= new Customer();
        customer.Name("Johnny Bravo");
        customer.SetAddress(address1);

        Customer customer1 = new Customer();
        customer1.Name("Jackie Chan");
        customer1.SetAddress(address);

        Order order1 = new Order();
        order1.SetCustomer(customer);
        order1.AddProduct(product1);

        Order order= new Order();
        order.SetCustomer(customer1);
        order.AddProduct(product2);
        
        Console.WriteLine("\nProduct:");
        Console.WriteLine(order.GetProductLabel());

        Console.WriteLine("\nShipping To:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\nTotal cost: $" + order.CalculateCost());

        Console.WriteLine("\nProduct:");
        Console.WriteLine(order1.GetProductLabel());

        Console.WriteLine("\nShipping To:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nTotal cost: $" + order1.CalculateCost());

        
    }
}