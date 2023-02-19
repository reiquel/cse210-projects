using System;

public class ScriptureHider
{
    public static string HideWords(Scripture scripture)
    {
        string[] words = scripture.Text.Split(' ');
        Random rand = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int index = rand.Next(0, words.Length);
            words[index] = "___";
        }

        return string.Join(" ", words);
    }
}