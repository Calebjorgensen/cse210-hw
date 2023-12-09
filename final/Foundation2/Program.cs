using System;


class Program
{
    static void Main(string[] args)
    {
        
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

        Address address3 =  new Address("789 Lane St", "Carville", "NY", "USA");
        Customer customer3 = new Customer("Seth Buck", address3);
        Product product4 = new Product("Xbox", "XB", 299, 1);
        List<Product> products3 = new List<Product> {product1, product2, product3, product4};
        Order order3 = new Order(customer3, products3);

        Console.WriteLine("");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~Order 1~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Total Price");
        Console.WriteLine("Total: " + order1.CalculateTotalCost());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~Order 2~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Total Price");
        Console.WriteLine("Total: " + order2.CalculateTotalCost());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~Order 3~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Total Price");
        Console.WriteLine("Total: " + order3.CalculateTotalCost());
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
    }
}