using System;

// Define the main class
class Program {
    static void Main(string[] args) {
        // Create some sample events
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Lecture lecture1 = new Lecture("Introduction to C#", "Learn the basics of C# programming", 
                                       new DateTime(2023, 4, 1), "2:00 PM", address1,
                                       "John Smith", 50);
        Reception reception1 = new Reception("Spring Mixer", "Come network with other professionals", 
                                             new DateTime(2023, 4, 15), "5:00 PM", address1,
                                             "rsvp@company.com");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "67890");
        OutdoorGathering outdoor1 = new OutdoorGathering("Summer Festival", "Celebrate the season with live music and food", 
                                                         new DateTime(2023, 6, 1), "10:00 AM", address2,
                                                         "Sunny and warm");

        // Call the marketing message methods for each event
        Console.WriteLine(lecture1.StandardDetails());
        Console.WriteLine(lecture1.FullDetails());
        Console.WriteLine(lecture1.ShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception1.StandardDetails());
        Console.WriteLine(reception1.FullDetails());
        Console.WriteLine(reception1.ShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoor1.StandardDetails());
        Console.WriteLine(outdoor1.FullDetails());
        Console.WriteLine(outdoor1.ShortDescription());
        Console.WriteLine();
    }
}