using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    class Reflection : Activity
    {
        private List<string> _prompts = new()
        {
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame a fear."
        };

        private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you feel during this experience?",
            "How could this help you in the future?"
        };

        public Reflection() : base("Reflection Activity",
            "This activity helps you reflect on times you showed strength and resilience.") { }

        public override void PerformActivity()
        {
            StartActivity();

            Random rand = new();
            Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
            ShowSpinner(5);

            int elapsed = 0;
            while (elapsed < _duration)
            {
                string question = _questions[rand.Next(_questions.Count)];
                Console.WriteLine($"\n> {question}");
                ShowSpinner(10);
                elapsed += 10;
            }

            EndActivity();
        }
    }
}

