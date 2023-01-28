using System;
using System.IO;

public class Questionnaire
{
    
    public string _questionnaire1 = "What was the best thing that happened to you today?";
    public string _questionnaire2 = "What country would you like to visit for the first time?";
    public string _questionnaire3 = "What do you feel is your purpose in life, and has that answer changed in the last five years?";
    public string _questionnaire4 = "What negative emotions am I holding onto? How can I let them go?";
    public string _questionnaire5 = "What negative emotions am I holding onto? How can I let them go?";

  
    public List<string> _questionnaire = new List<string>();

    public string DisplayQuestionnaire()
    {
        var random = new Random();
        return _questionnaire[random.Next(_questionnaire.Count)];
    }
    
}