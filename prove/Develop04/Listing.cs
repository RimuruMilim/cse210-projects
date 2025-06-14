using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    class Listing : Activity
    {
        private List<string> _prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "What are things you're grateful for today?",
            "Who are your personal heroes?"
        };

        public Listing() : base("Listing Activity",
            "This activity helps you list positive things in your life.") { }

        public override void PerformActivity()
        {
            StartActivity();

            Random rand = new();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine($"\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("You may begin in: ");
            Countdown(5);

            int count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                count++;
            }

            Console.WriteLine($"\nYou listed {count} items!");
            EndActivity();
        }
    }
}
