using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Please enter your favorite number: ");
        double number = double.Parse(Console.ReadLine());
        double square = SquareCalc(number);

        Console.Write($"{name}, the square of your number is {square}.");

    }

    static double SquareCalc(double num)
    {
        double square = num * num;
        return square;
    }
}