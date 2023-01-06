using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = " ";
        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else  {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70){
            Console.WriteLine("You passed the class, congratulations!");
        }
        else {
            Console.WriteLine("We encorage you to keep on trying, you did not pass the class this time");
        }
    }
}