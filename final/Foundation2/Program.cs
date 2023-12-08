using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address("123 Campbell Drive", "Nowhereville", "UT", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);
        Product product1 = new Product("Fishing Pole", "FP", 15.99, 1);
        Product product2 = new Product("Video Game Controller", "VGC", 59.99, 1);
        List<Product> products1 = new List<Product> {product1, product2};
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("456 anywhere road", "Nothing Town", "Ab", "CA");
        Customer customer2 = new Customer("John Doe", address2);
        Product product3 = new Product("WaterBottle", "WB", 34.99, 2);
        List<Product> products2 = new List<Product> {product1, product3};
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 - Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("Order 1 - Total Price");
        Console.WriteLine(order1.CalculateTotalCost());

        
    }
}