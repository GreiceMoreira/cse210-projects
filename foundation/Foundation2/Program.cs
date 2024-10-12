using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)

    {
        Address address1 = new Address("Namur" , "Quebec" , "Quebec", "Canada");
        Customer customer1 = new Customer("Paulo" , address1);
        Product product1 = new Product("caneta" , 1 , 12 , 5);
        Product product2 = new Product("caderno" , 2 , 15 , 7);
        Order order1 = new Order(customer1);
        order1.AddInList(product1);
        order1.AddInList(product2);

        Address address2 = new Address("Namur" , "Quebec" , "Quebec", "USA");
        Customer customer2 = new Customer("Joao" , address2);
        Order order2 = new Order(customer2);
        order2.AddInList(product1);
        order2.AddInList(product2);

        Address address3 = new Address("Namur" , "Quebec" , "Quebec", "Canada");
        Customer customer3 = new Customer("Ana" , address3);
        Product product3 = new Product("caneta" , 1 , 12 , 4);
        Order order3 = new Order(customer3);
        order3.AddInList(product3);
        order3.AddInList(product2);


        Console.WriteLine($"shipping: {order1.Shipping()}");
        // Exibindo a etiqueta de embalagem
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.PackingLabel());

        // Exibindo a etiqueta de envio
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine("--------------");

        Console.WriteLine($"shipping: {order2.Shipping()}");
        // Exibindo a etiqueta de embalagem
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.PackingLabel());

        // Exibindo a etiqueta de envio
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());


        Console.WriteLine("--------------");

        
        // Exibindo a etiqueta de embalagem
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order3.PackingLabel());

        // Exibindo a etiqueta de envio
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.GetTotalCost());



        //Once you have created these classes, 
        //write a program that creates at least two orders with a 2-3 products each. 
        //Call the methods to get the packing label, the shipping label, 
        //and the total price of the order, and display the results of these methods.

    }
}