
using System;

class Product
{
    // Class variable to keep track of the total number of products created
    public static int totalProducts = 0;

    // Instance variables
    public string productName;
    public double price;

    // Constructor to initialize the product
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
		
        // Increment totalProducts whenever a new product is created
        totalProducts++;
    }

    // Instance method to display the product's details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: {price}");
    }

    // Class method to display the total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}

class Program
{
    static void Main()
    {
        // Creating product instances
        Product product1 = new Product("Laptop", 99999);
        Product product2 = new Product("Smartphone", 49999);

        // Displaying product details
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();

        // Displaying total products
        Product.DisplayTotalProducts();
    }
}

