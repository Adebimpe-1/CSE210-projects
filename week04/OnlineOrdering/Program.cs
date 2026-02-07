using System;

class Program
{
    static void Main(string[] args)
    {
        // Requirement #3: Create 2+ Orders with 2+ Products each
        // Order 1: USA customer
        Address usaAddress = new Address("123 Main St", "Provo", "UT", "USA");
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Order order1 = new Order(usaCustomer);

        order1.AddProduct(new Product("Widget A", "W001", 10.0, 2));
        order1.AddProduct(new Product("Widget B", "W002", 15.0, 1));

        // Order 2: International customer
        Address intlAddress = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer intlCustomer = new Customer("Jane Smith", intlAddress);
        Order order2 = new Order(intlCustomer);

        order2.AddProduct(new Product("Gadget X", "G001", 25.0, 3));
        order2.AddProduct(new Product("Gadget Y", "G002", 8.0, 4));

        // Requirement #4: Display totals, labels for each order
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotal():F2}");
        Console.WriteLine();

        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal():F2}");
    }
}
