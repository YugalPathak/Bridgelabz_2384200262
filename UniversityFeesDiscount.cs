using System;

namespace Calculate
{
    public class UniversityFeesDiscount
    {
        public static void Main(string[] args)
        {
            // Creating an object of UniversityFeesDiscount class
            UniversityFeesDiscount f1 = new UniversityFeesDiscount();
            
            // Calling the method to calculate the discount on university fees
            f1.CalculateDiscount();
        }

        public void CalculateDiscount()  // Method to calculate the discount on university fees
        {
            // Creating variables to store values for fee and discount percentage
            int fee = 125000;
            int discountPercent = 10;
            
            // Calculating the discount amount using the formula: (fee * discountPercent) / 100
            int discountAmount = (fee * discountPercent) / 100;
            
            // Calculating the final discounted fees by subtracting the discount amount from the original fee
            int finalDiscountedFees = fee - discountAmount;
            
            // Displaying the result: discount amount and final discounted fee
            Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalDiscountedFees}");
        }
    }
}
