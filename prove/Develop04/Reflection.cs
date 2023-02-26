
using System;
// Class for the Reflection activity
// Class for the Reflection activity
public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    // Method to run the Reflection activity
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
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string[][] questions = {
            new string[] {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            }
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this.Duration);

        while (DateTime.Now < endTime)
        {
            Random rand = new Random();
            int promptIndex = rand.Next(prompts.Length);
            int questionIndex = rand.Next(questions.Length);
            
            Console.WriteLine(prompts[promptIndex]);
            System.Threading.Thread.Sleep(1000);

            foreach (string question in questions[questionIndex])
            {
                Console.Write("+");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("-"); // Replace it with the character
                System.Threading.Thread.Sleep(1000);
                Console.Write("+");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("-");
                Console.WriteLine(question);
                System.Threading.Thread.Sleep(1000);

                
            }
        }

        this.DisplayEndMessage();
    }
}
