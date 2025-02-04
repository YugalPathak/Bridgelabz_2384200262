using System;

class Product
{
    // Static variable shared by all products
    public static double Discount = 0.0;

    // Static method to update the discount percentage
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine($"Discount updated to: {Discount}%");
    }

    // Readonly variable for unique product ID
    public readonly int ProductID;

    // Instance properties
    public string ProductName { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    // Constructor using 'this' to initialize properties
    public Product(int productID, string productName, double price, int quantity)
    {
        this.ProductID = productID;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Method to display product details
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price:C}, Quantity: {Quantity}, Discount: {Discount}%");
    }
}

class Program
{
    private static Product[] cart = new Product[100];
    private static int productCount = 0;
    private static int currentProductID = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nShopping Cart System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. View Cart");
            Console.WriteLine("4. Calculate Total");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    RemoveProduct();
                    break;
                case 3:
                    DisplayCart();
                    break;
                case 4:
                    CalculateTotal();
                    break;
                case 5:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddProduct()
    {
        if (productCount >= cart.Length)
        {
            Console.WriteLine("Cart is full. Cannot add more products.");
            return;
        }

        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        if (!double.TryParse(Console.ReadLine(), out double price))
        {
            Console.WriteLine("Invalid price input.");
            return;
        }

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity input.");
            return;
        }

        cart[productCount++] = new Product(currentProductID++, name, price, quantity);
        Console.WriteLine("Product added successfully.");
    }

    private static void RemoveProduct()
    {
        Console.Write("Enter Product ID to remove: ");
        if (!int.TryParse(Console.ReadLine(), out int productId))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        int indexToRemove = -1;
        for (int i = 0; i < productCount; i++)
        {
            if (cart[i].ProductID == productId)
            {
                indexToRemove = i;
                break;
            }
        }

        if (indexToRemove == -1)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        // Shift elements to remove the product
        for (int i = indexToRemove; i < productCount - 1; i++)
        {
            cart[i] = cart[i + 1];
        }

        cart[--productCount] = null;
        Console.WriteLine("Product removed successfully.");
    }

    private static void DisplayCart()
    {
        if (productCount == 0)
        {
            Console.WriteLine("Cart is empty.");
            return;
        }

        Console.WriteLine("Shopping Cart:");
        for (int i = 0; i < productCount; i++)
        {
            if (cart[i] is Product product)
            {
                product.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Error: Invalid product found in cart.");
            }
        }
    }

    private static void CalculateTotal()
    {
        if (productCount == 0)
        {
            Console.WriteLine("Cart is empty.");
            return;
        }

        double total = 0;
        foreach (var product in cart)
        {
            if (product != null)
            {
                total += product.Price * product.Quantity;
            }
        }

        double discountAmount = total * (Product.Discount / 100);
        double finalTotal = total - discountAmount;

        Console.WriteLine($"Total before discount: {total:C}");
        Console.WriteLine($"Discount applied: {discountAmount:C}");
        Console.WriteLine($"Final Total: {finalTotal:C}");
    }
}