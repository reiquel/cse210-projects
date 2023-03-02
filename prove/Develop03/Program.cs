using System;
using System.Collections.Generic;


    class Program
    {


     public static void Main()
    {
        Scripture scripture = new Scripture("Proverbs 3:5-6", 
            "Trust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.Reference}: {scripture.Text}");

            Console.Write("\nPress enter or type quit: ");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }
            
            else
            {
                scripture.Text = ScriptureHider.HideWords(scripture);
            }
        }
    }
}
        
    

