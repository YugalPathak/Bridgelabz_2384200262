using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}

class Order
{
    public int OrderId { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        Products = new List<Product>();
        OrderDate = DateTime.Now;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine($"{product.Name} has been added to Order #{OrderId}");
    }

    public decimal GetTotalAmount()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }

    public override string ToString()
    {
        return $"Order #{OrderId} for {Customer.Name} - Total: ${GetTotalAmount()}";
    }
}

class Customer
{
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer(string name)
    {
        Name = name;
        Orders = new List<Order>();
    }

    public void PlaceOrder(Order order)
    {
        Orders.Add(order);
        Console.WriteLine($"{Name} placed Order #{order.OrderId}");
    }

    public void ShowOrderHistory()
    {
        Console.WriteLine($"{Name}'s Order History:");
        foreach (var order in Orders)
        {
            Console.WriteLine(order);
        }
    }
}

class ECommercePlatform
{
    public List<Customer> Customers { get; set; }
    public List<Product> Products { get; set; }

    public ECommercePlatform()
    {
        Customers = new List<Customer>();
        Products = new List<Product>();
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void ShowPlatformInfo()
    {
        Console.WriteLine("E-Commerce Platform Info:");
        Console.WriteLine("Products Available:");
        foreach (var product in Products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create an E-commerce platform
        ECommercePlatform platform = new ECommercePlatform();

        // Add products to the platform
        Product product1 = new Product("PS5", 999.99m);
        Product product2 = new Product("Toy Car", 599.99m);
        Product product3 = new Product("Earphones", 149.99m);
        platform.AddProduct(product1);
        platform.AddProduct(product2);
        platform.AddProduct(product3);

        // Show available products on the platform
        platform.ShowPlatformInfo();

        // Create a customer
        Customer customer1 = new Customer("Yugal");

        // Add the customer to the platform
        platform.AddCustomer(customer1);

        // Create an order for the customer
        Order order1 = new Order(1001, customer1);

        // Customer places the order
        customer1.PlaceOrder(order1);

        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Show the order and its total amount
        Console.WriteLine(order1);

        // Create another order for the customer
        Order order2 = new Order(1002, customer1);
        customer1.PlaceOrder(order2);
        order2.AddProduct(product3);

        // Show the customer's order history
        customer1.ShowOrderHistory();
    }
}