using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name =  PromptUserName();
        int uNumber =  PromptUserNumber();
        int sNumber =  SquareNumber(uNumber);

        displayResult(name, sNumber);
    }
    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the pogram!");
    }
    
    static string PromptUserName()
    {
    Console.WriteLine("Please enter your name: ");
    string input = Console.ReadLine();
    return input;
    }
    static int PromptUserNumber() {    
    Console.WriteLine("Please enter your favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
    }
    static int SquareNumber(int number) {
    int squareRoot = number * number;

    return squareRoot;
    }

    static void displayResult(string input, int squareRoot)
    {
        Console.WriteLine($"{input}, the square of your number is {squareRoot}");
    }
}

