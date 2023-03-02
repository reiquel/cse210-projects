using System;

class Journal
{
    static void Main(string[] args)
   {
        diary.PrintHomeScreen();
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1 - Write");
        Console.WriteLine("2 - Display");
        Console.WriteLine("3 - Delete entries");
        Console.WriteLine("4 - End");
        choice = Console.ReadKey().KeyChar;
        Console.WriteLine();
        // Selecting an option
        switch (choice)
        {
            case '1':
                diary.AddEntry();
                break;
            case '2':
                diary.SearchEntries();
                break;
            case '3':
                diary.DeleteEntries();
                break;
            case '4':
                Console.WriteLine("Press any key to quit the program...");
                break;
            default:
                Console.WriteLine("Error. Press any key to choose another action.");
                break;
        }
        Console.ReadKey();
    }
}
