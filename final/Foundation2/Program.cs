using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Address usaAddress = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Widget", "W1", 10.0m, 2));
        usaOrder.AddProduct(new Product("Gadget", "G1", 20.0m, 1));
        Console.WriteLine("Packing label:\n" + usaOrder.PackingLabel());
        Console.WriteLine("Shipping label:\n" + usaOrder.ShippingLabel());
        Console.WriteLine("Total price: $" + usaOrder.TotalPrice());
        
        Address nonUsaAddress = new Address("456 High St", "Anytown", "ON", "Canada");
        Customer nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);
        Order nonUsaOrder = new Order(nonUsaCustomer);
        nonUsaOrder.AddProduct(new Product("Widget", "W2", 12.0m, 1));
        nonUsaOrder.AddProduct(new Product("Gadget", "G2", 22.0m, 2));
        Console.WriteLine("\nPacking label:\n" + nonUsaOrder.PackingLabel());
        Console.WriteLine("Shipping label:\n" + nonUsaOrder.ShippingLabel());
        Console.WriteLine("Total price: $" + nonUsaOrder.TotalPrice());
    }
}