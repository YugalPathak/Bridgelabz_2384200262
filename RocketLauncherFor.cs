using System;

public class RocketLauncher
{
	// Creating a method CountDown to launch the rocket 
	public void CountDown()
	{
		// Taking user input to enter the counter value
        Console.Write("Enter the countdown start value: ");
        int counter = Convert.ToInt32(Console.ReadLine());
        
		// for loop is used to print the value of counter 
        for ( ;counter >= 1 ; counter--)
        {
            Console.WriteLine(counter);
		}	
    }
		
    public static void Main(String[] args)
    {
		// Creating an object of the classname
        RocketLauncher cd = new RocketLauncher();
		
		// Creating the method
		cd.CountDown();
            
    }
}
