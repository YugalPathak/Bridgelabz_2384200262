using System;

namespace Calculate
{
    public class ItemPrice
    {
        public static void Main(string[] args)
        {
            // Creating object of ItemPrice class
            ItemPrice item1 = new ItemPrice();
            
            // Calling method to calculate the total price of the item
            item1.CalculatePrice();
        }

        public void CalculatePrice()  // Method to calculate total price of the item
        {
            // Prompting user to enter the unit price of the item
            Console.WriteLine("Enter unit price of item in rupees: ");
            
            // Taking input for unit price of the item
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            
            // Prompting user to enter the quantity of the item
            Console.WriteLine("Enter quantity of item: ");
            
            // Taking input for quantity of the item
            double quantity = Convert.ToDouble(Console.ReadLine());
            
            // Calculating the total price
            double totalPrice = unitPrice * quantity;
            
            // Displaying the result (total price and quantity)
            Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and unit price is INR {unitPrice}");
        }
    }
}
