using System;

// Class for the Breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    // Method to run the Breathing activity
    public void RunActivity()
    {
        Console.WriteLine("Prepare to begin...");
        System.Threading.Thread.Sleep(1000);
 		int startTime1 = 3;
		
		// Loop until we reach 0 or less
		while (startTime1 > 0)
		{
			// Print out the time
			Console.WriteLine(startTime1);
			
			// Decrement the time
			startTime1--;
			
			// Sleep for 1 second
			System.Threading.Thread.Sleep(1000);
		}

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r|");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r/");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r-");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r\\");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r|");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nBreathe out...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r|");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r/");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r-");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r\\");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r|");
            System.Threading.Thread.Sleep(1000);
        }

        this.DisplayEndMessage();
    }
}
