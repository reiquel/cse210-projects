using System;

public class promptGenerator
{
   public static void Main()
   {
      Random random = new Random();
      string[] _journalQuestions = { 
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
      int mIndex = random.Next(_journalQuestions.Length);

      // Display the result.
      Console.Write(_journalQuestions[mIndex]);
      string _eJournal = Console.ReadLine();
      
      Console.WriteLine($"{_eJournal}");

   }

}
  