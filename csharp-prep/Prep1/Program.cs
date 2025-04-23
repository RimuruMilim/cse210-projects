using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        /*The users input for first name*/
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        /*The users input for last name*/
        Console.WriteLine("What is your last name? ");
        string last_name = Console.ReadLine();

        //Using the previous 2 inputs, output an "f" string like in python but with $
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}