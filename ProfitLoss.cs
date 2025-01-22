using System;

namespace Calculate
{
    public class ProfitLoss
    {
        public static void Main(string[] args)
        {
            // Creating object of the ProfitLoss class
            ProfitLoss pl = new ProfitLoss();
            
            // Calling the Profit method to calculate profit and profit percentage
            pl.Profit();
        }

        public void Profit()  // Method to calculate profit and profit percentage
        {
            // Creating variables to store the cost price and selling price
            double costPrice = 129;
            double sellingPrice = 191;

            // Calculating the profit
            double profitAmount = sellingPrice - costPrice;

            // Calculating the profit percentage
            double profitPercentage = (profitAmount / costPrice) * 100;

            // Printing the results: cost price, selling price, profit, and profit percentage
            Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}");
            Console.WriteLine($"The Profit is INR {profitAmount} and the Profit Percentage is {profitPercentage}%");
        }
    }
}
