using System;

class Program
{
    static void Main(string[] args)
    {
                // Order 1

        //products
        Product product1 = new Product("Product 1", "P001", 10.99, 2);
        Product product2 = new Product("Product 2", "P002", 7.49, 3);

        // Create customer and address
        Address customerAddress1 = new Address("123 Main St", "Sacramento", "CA", "USA");
        Customer customer1 = new Customer("John Bonham", customerAddress1);

        // Create products list
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);

        // Create order
        Order order1 = new Order(products1, customer1);

        // Display packing label, shipping label, and total cost
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackagingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.TotalPrice():0.00}");
        Console.WriteLine();
        Console.WriteLine("____________________________________________________________________________");

                // Order 2

        //products
        Product product3 = new Product("Product 3", "P003", 12.99, 2);
        Product product4 = new Product("Product 4", "P004", 74.49, 2);
        Product product5 = new Product("Product 5", "P005", 17.49, 1);

        // Create customer and address
        Address customerAddress2 = new Address("18 de Julio 711", "San Jose", "MVD", "Uruguay");
        Customer customer2 = new Customer("John Bonham", customerAddress2);

        // Create products list
        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);
        products2.Add(product5);

        // Create order
        Order order2 = new Order(products2, customer2);

        // Display packing label, shipping label, and total cost
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackagingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.TotalPrice():0.00}");
        Console.WriteLine();
        Console.WriteLine("____________________________________________________________________________");


    }
}