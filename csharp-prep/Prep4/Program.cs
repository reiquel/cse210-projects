

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
    int number = -1;
    while (number != 0 ) {
    Console.Write("Enter a list of numbers, type 0 when finished: ");
      number =  int.Parse(Console.ReadLine());
    if (number !=0 ){
    numbers.Add(number);}
      }
    int total = 0;
    foreach (int i in numbers) {
      total += i;
    }
      
    Console.WriteLine($"The sum is: {total}");
    
    float average = ((float)total) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int largest = numbers[0];
    foreach (int num in numbers) {
      if(num > largest){
       largest =  number;
      }
    }
    Console.WriteLine($"The largest is: {largest}");

    }
}