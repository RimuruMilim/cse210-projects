using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<double> numbers = new List<double>();
        string userInput;
        double userNumber;
        double sum = 0;
        
        //double average = 0;
        
        Console.Write("Please enter numbers (type 'exit' to quit): ");
        
        do
        {
            Console.Write("Enter a number: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "exit")
            {
                if (double.TryParse(userInput, out userNumber))
                {
                    numbers.Add(userNumber);
                }
                else
                {
                    Console.Write("That's not a valid number, please try again. ");
                }
            }
        }while (userInput.ToLower() != "exit");

        double largest = numbers[0];

        foreach (var number in numbers)
        {
            sum += number;
            Console.WriteLine(number);
            if (number > largest)
            {
                largest = number;
            }
        }

        double average = sum / numbers.Count;
        Console.WriteLine($"Sum is: {sum}");
        Console.WriteLine($"Average is: {average}");
        Console.WriteLine($"Largest number is: {largest}");
    }
}