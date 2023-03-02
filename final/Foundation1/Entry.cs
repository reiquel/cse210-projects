using System;
using System.IO; 
public class Entry
{
   public static void Main()
   {
      Random random = new Random();
      string[] journalQuestions = { 
      "What was the best thing that happened to you today?", 
      "What steps did you take today towards a goal you're working on?", 
      "What are three things you're grateful for today?", 
      "What country would you like to visit for the first time?", 
      "What magic power would you like to have?", 
      "What do you feel is your purpose in life, and has that answer changed in the last five years?", 
      "What is your happy place? Describe it in detail", 
      "Where do you see yourself in 10 years? 20?", 
      "What negative emotions am I holding onto? How can I let them go?",
      "What goals have you lost sight of? Are you interested in picking them up again?",
      "What do you want to be remembered for?" };
                                     

      // Generate random indexes for journalQuestions. 
      int mIndex = random.Next(journalQuestions.Length);

      // Display the result.
      Console.Write(journalQuestions[mIndex]);
      string eJournal = Console.ReadLine();
      
      Console.WriteLine($"{journalQuestions[mIndex]}{eJournal}");
     string eJournalCombine = Console.ReadLine();
    string currentDate1 = DateTime.Now.ToString("MM/dd/yyyy");

Console.Write("What is the file name: ");
string fileInput = Console.ReadLine();
string fileName = fileInput;

using (StreamWriter outputFile = new StreamWriter(fileName))
{
  
    outputFile.WriteLine("This will be the first line in the file.");
  

    outputFile.WriteLine($" {currentDate1} {journalQuestions[mIndex]} {eJournal}");
      string textFileContent = File.ReadAllText(fileName);
            System.Console.WriteLine(textFileContent);
}
      
   }
}