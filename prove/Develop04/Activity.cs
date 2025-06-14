using System;
using System.Threading;

namespace MindfulnessApp
{
    abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine(_description);
            Console.Write("How long would you like this session to last (in seconds)? ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(5);
        }

        public void EndActivity()
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(2);
            Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
            ShowSpinner(8);
        }

        protected void ShowSpinner(int seconds)
        {
            string[] spinner = { "/", "-", "\\", "|" };
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > -1; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
        }

        public abstract void PerformActivity();
    }
}
