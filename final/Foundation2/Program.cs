using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "Idaho Falls",
            "Idaho",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K101", 45.00, 1));
        order1.AddProduct(new Product("Mouse", "M202", 20.00, 2));
        order1.AddProduct(new Product("Mouse Pad", "P303", 10.00, 1));

        Address address2 = new Address(
            "45 Maple Road",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Sarah Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "H404", 60.00, 1));
        order2.AddProduct(new Product("Webcam", "W505", 35.00, 2));

        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}