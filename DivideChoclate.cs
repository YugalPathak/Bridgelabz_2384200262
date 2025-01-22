using System;

namespace Calculate
{
    public class DivideChocolate
    {
        public static void Main(string[] args)
        {
            // Creating object
            DivideChocolate d1 = new DivideChocolate();
            
            // Calling EqualChocolateDivide function
            d1.EqualChocolateDivide();
        }

        public void EqualChocolateDivide()
        {
            // Get input from user
            Console.Write("Enter number of chocolates: ");
            int chocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of children: ");
            int children = Convert.ToInt32(Console.ReadLine());

            // Check for division by zero
            if (children == 0)
            {
                Console.WriteLine("Number of children cannot be zero.");
                return;
            }

            // Calculate chocolates per child and remaining chocolates
            int chocolatesPerChild = chocolates / children;
            int remainingChocolates = chocolates % children;

            // Display results
            Console.WriteLine($"Each child gets: {chocolatesPerChild}");
            Console.WriteLine($"Remaining chocolates: {remainingChocolates}");
        }
    }
}