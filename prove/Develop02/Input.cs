using System;
using System.IO;


public class Input {


    public string _date;
    public string _questionnaireQuestion;
    public string _userResponse;


    
    public void DisplayInput() {


        Console.WriteLine($"{_date} - {_questionnaireQuestion} - {_userResponse}");
      
    }
}