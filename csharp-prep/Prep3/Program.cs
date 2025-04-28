using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101); // Generates a number from 0 to 99
        int userGuess = 0;
        Console.Write("Guess a random number from 1 - 100: ");
        do
        {
            string response = Console.ReadLine();
            
            if (int.TryParse(response, out userGuess))
            {
                if (userGuess < randomNumber)
                {
                    Console.Write("Too low! Try again. ");
                }
                else if (userGuess > randomNumber)
                {
                    Console.Write("Too high! Try again. ");
                }
                else
                {
                    Console.Write("Congratulations! You guessed the correct number!");
                }
            }
            else
            {
                Console.Write("Please enter a valid number. ");
            }
            
        }while (userGuess != randomNumber);
    }
}