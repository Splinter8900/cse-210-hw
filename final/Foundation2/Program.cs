using System;


class Program {
    static void Main(string[] args) 
    {
        //Order 1
        Address address1 = new Address("400S 50E", "Brigham City", "UT", "12345", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product[] products1 = 
        {
            new Product("Frying Pan", 100, 10.0, 1),
            new Product("Rubber Spatula", 101, 15.89, 3),
            new Product("Towel Set", 102, 20.50, 1)
        };
        Order order1 = new Order(customer1, products1);

        //Order 2
        Address address2 = new Address("90W 300 N", "Raymond", "AB","T0K2S0", "Canada");
        Customer customer2 = new Customer("Ben Shurtz", address2);
        Product[] products2 = 
        {
            new Product("Computer", 103, 1200.99, 1),
            new Product("Nerf Darts", 104, 20.99, 4),
            new Product("Butterfly Knife", 6, 85.50, 1),
            new Product("Fountain Pens", 105, 19.99, 1)
        };
        Order order2 = new Order(customer2, products2);

        //Order 3
        Address address3 = new Address("42 E 100N ", "Magrath", "AB", "4P4 3N3", "Canada");
        Customer customer3 = new Customer("Denon Charles", address3);
        Product[] products3 = 
        {
            new Product("Hair Dryer", 106, 5.99, 1),
            new Product("Shampoo", 107, 19.99, 3),
            new Product("Brush", 108, 15.99, 2),
        };
        Order order3 = new Order(customer3, products3);

        Console.WriteLine("\nOrder 1:");
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice()}$\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice()}$\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine($"Total Price: {order3.CalculateTotalPrice()}$\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.ShippingLabel());
    }
}