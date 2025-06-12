class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        var address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("Alice Johnson", address1);
        var customer2 = new Customer("Bob Smith", address2);

        // Create products
        var product1 = new Product("Keyboard", "P001", 49.99m, 2);
        var product2 = new Product("Mouse", "P002", 19.99m, 1);
        var product3 = new Product("Webcam", "P003", 89.99m, 1);
        var product4 = new Product("Monitor", "P004", 199.99m, 2);

        // Create orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store orders in a list
        var orders = new List<Order> { order1, order2 };

        // Display all order info
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
