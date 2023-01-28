using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
       
        Diary currentDiary = new Diary();
        string start = "y";

     
        Questionnaire questionnaireForUser = new Questionnaire();
        questionnaireForUser._questionnaire.Add(questionnaireForUser._questionnaire1);
        questionnaireForUser._questionnaire.Add(questionnaireForUser._questionnaire2);
        questionnaireForUser._questionnaire.Add(questionnaireForUser._questionnaire3);
        questionnaireForUser._questionnaire.Add(questionnaireForUser._questionnaire4);
        questionnaireForUser._questionnaire.Add(questionnaireForUser._questionnaire5);

    

        Console.WriteLine();
        Console.WriteLine("Welcome to your Personal Diary!");
        Console.Write("Would you like to continue to the main menu? Y/N: ");
        Console.ReadLine();

        if (start == "y")
        {
            int userSelection = 0;

            while (userSelection != 5)
            {
                Console.WriteLine("Please select of one of the following choices: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                userSelection = int.Parse(Console.ReadLine());
                
                if (userSelection == 1)
                {
                    Input currentInput = new Input();

                  
                    DateTime theCurrentTime = DateTime.Now;
                    currentInput._date = theCurrentTime.ToShortDateString();

                 
                    currentInput._questionnaireQuestion = questionnaireForUser.DisplayQuestionnaire();
                    Console.WriteLine(currentInput._questionnaireQuestion);

                   
                    currentInput._userResponse = Console.ReadLine();

                    currentDiary._entries.Add(currentInput);
                }

                else if (userSelection == 2)
                {
                    currentDiary.DisplayDiary();
                }

                else if (userSelection == 3)
                {
                    currentDiary = new Diary();
                    Console.Write("Which file would you like the open? ");
                    currentDiary._fileName = Console.ReadLine();
                    currentDiary.LoadFile();
                }

                else if (userSelection == 4)
                {
                    currentDiary.SaveFile();
                    Console.WriteLine("The file has been saved");
                }
            }
        }

        else
        {
            Console.WriteLine("See you again sometime");
            System.Environment.Exit(1);
        }


    }
}