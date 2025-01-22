using System;

namespace Calculate
{
    public class FeesDiscount
    {
        public static void Main(string[] args)
        {
            // Creating object of UniversityFeesDiscount class
            UniversityFeesDiscount f1 = new UniversityFeesDiscount();
            
            // Calling method to calculate the discount
            f1.CalculateDiscount();
        }

        public void CalculateDiscount()  // Method to calculate the discount and final discounted fees
        {
            // Prompting user to enter the fee amount
            Console.WriteLine("Enter fees amount in rupees: ");
            
            // Taking input for the fee amount
            double fee = Convert.ToDouble(Console.ReadLine());
            
            // Prompting user to enter the discount percentage
            Console.WriteLine("Enter discount percent: ");
            
            // Taking input for the discount percentage
            double discountPercent = Convert.ToDouble(Console.ReadLine());
            
            // Calculating the discount amount
            double discount = (fee * discountPercent) / 100;
            
            // Calculating the final discounted fee
            double finalDiscountedFees = fee - discount;
            
            // Displaying the discount amount and final discounted fee
            Console.WriteLine($"The discount amount is INR {discount} and the final discounted fee is INR {finalDiscountedFees}");
        }
    }
}
