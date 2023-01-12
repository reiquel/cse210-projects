using System;

class Program
{
    static void Main(string[] args)
    {
            int guess = -1;
  

      Random randomNumber =  new Random();
      int number = randomNumber.Next(1, 100);
    while (guess != number) 
    
    {
      Console.WriteLine ("What is your guess?");
      guess = int.Parse(Console.ReadLine());
      if (guess > number) {
      Console.WriteLine("Lower");
    }
      else if (guess < number) {
      Console.WriteLine("Higher");
    }
     else {
      Console.WriteLine("You guessed it");
          
    }
    }
} }