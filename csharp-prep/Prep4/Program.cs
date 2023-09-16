using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //create list to store numbers
        List<int> numbers = new List<int>();

        //define variable for the do while loop
        int userNumber = 1;

        //title
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        do
        {
            //ask the user to input a number
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            // add number to the numbers list
            if (!(userNumber == 0))
            {
                numbers.Add(userNumber);
            }           
        
        } while (!(userNumber == 0));

        //print list
        Console.WriteLine("Numbers List: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }     

        //sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");         

        //average
        float avg = (float)numbers.Average();
        Console.WriteLine($"The average is: {avg}");

        //largest number  
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}"); 

        //smallest positive number
        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }


        //sorted list
        numbers.Sort();
        Console.WriteLine("Sorted List: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }   

        
    }
}