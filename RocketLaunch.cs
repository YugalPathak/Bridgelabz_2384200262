using System;

public class Rocket
{
      public static void Main(String[] args)
      {
		// Creating an object of the classname
            Rocket r1 = new Rocket();
		
		// Creating the method
		r1.Count();

      }
	// Creating a method CountDown to launch the rocket 
	public void Count()
	{
		// Taking user input to enter the counter value
            Console.Write("Enter the countdown start value: ");
            int counter = Convert.ToInt32(Console.ReadLine());
        
		// while loop is used to print the value of counter 
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--; // Decrement the counter
		 }	
      }
		
      
}