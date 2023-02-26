using System;

// Class for the Listing activity
public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    // Method to run the Listing activity
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

        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.Duration);

        int numItems = 0;

        while (DateTime.Now < endTime)
        {
            Random rand = new Random();
            int promptIndex = rand.Next(prompts.Length);

            Console.WriteLine(prompts[promptIndex]);
            System.Threading.Thread.Sleep(3000);

            string item;
            do
            {
                Console.Write("Item: ");
                item = Console.ReadLine();

                if (!string.IsNullOrEmpty(item))
                {
                    numItems++;
                }
            } while (!string.IsNullOrEmpty(item) && DateTime.Now < endTime);
        }

        this.DisplayEndMessage();
        Console.WriteLine("You have listed " + numItems + " items.");
    }
}

