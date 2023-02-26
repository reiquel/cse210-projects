using System;

public class Program
{
 public static void Main(string[] args)
    {
        // Variable to hold the user choice
        int choice;

        // Do while loop to keep the program running until the user chooses to quit
        do
        {
            // Display the menu
            Console.WriteLine("---Menu of Activities:---");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. log Activity");
            Console.WriteLine("5. quit");
            Console.WriteLine();
            // Get the user choice
            Console.Write("Please select an activity: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Create a new instance of BreathingActivity
                    BreathingActivity breathingActivity = new BreathingActivity();

                    // Display the start message
                    breathingActivity.DisplayStartMessage();

                    // Get the user input for the duration
                    breathingActivity.Duration = int.Parse(Console.ReadLine());

                    // Run the activity
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    // Create a new instance of ReflectionActivity
                    ReflectionActivity reflectionActivity = new ReflectionActivity();

                    // Display the start message
                    reflectionActivity.DisplayStartMessage();

                    // Get the user input for the duration
                    reflectionActivity.Duration = int.Parse(Console.ReadLine());

                    // Run the activity
                    reflectionActivity.RunActivity();
                    break;
                case 3:
                    // Create a new instance of ListingActivity
                    ListingActivity listingActivity = new ListingActivity();

                    // Display the start message
                    listingActivity.DisplayStartMessage();

                    // Get the user input for the duration
                    listingActivity.Duration = int.Parse(Console.ReadLine());

                    // Run the activity
                    listingActivity.RunActivity();
                    break;
                case 4:
                    // Log the activities that have been completed
                   LogActivity.Log();
                    break;
            }
        } while (choice != 5);
    }
}
