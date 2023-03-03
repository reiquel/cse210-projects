using System;
using System.IO; 


public class Diary
{
   
    public string _fileName;

   
    public List<Input> _entries = new List<Input>();
// Good job

    public void DisplayDiary()
    {   
        foreach (Input input in _entries)
        {
            input.DisplayInput();
            
        }
    }

    
    public void SaveFile()
    {
        Console.WriteLine("What is the file name? ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Input input in _entries)
            {
                outputFile.WriteLine($"{input._date} - {input._questionnaireQuestion} - {input._userResponse}");
          
            }
        }
    }


    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Input theInput = new Input();
            string[] parts = line.Split("-");

            theInput._date = parts[0];
            theInput._questionnaireQuestion = parts[1];
            theInput._userResponse = parts[2];

            _entries.Add(theInput);
        }
        DisplayDiary();
    }

}