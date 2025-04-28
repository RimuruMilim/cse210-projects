using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Give me your score: ");
        string Userinput = Console.ReadLine();
        double score = double.Parse(Userinput);
        if (score >= 90)
        {
            Console.Write("Your grade is an A");
        }
        else if (score >= 80)
        {
            Console.Write("Your grade is a B");
        }
        else if (score >= 70)
        {
            Console.Write("Your grade is a C");
        }
        else if (score >= 60)
        {
            Console.Write("Your grade is a D");
        }
        else if (score < 60)
        {
            Console.Write("Your grade is an F");
        }
        else
        {
            Console.Write("That is not an applicable answer");
        }
    }
}