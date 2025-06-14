using System;
using System.Threading;

namespace MindfulnessApp
{
    class Breathing : Activity
    {
        public Breathing() : base("Breathing Activity",
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.") { }

        public override void PerformActivity()
        {
            StartActivity();

            int elapsed = 0;
            while (elapsed < _duration)
            {
                Console.Write("\nBreathe in...");
                Countdown(4);
                Console.Write("\nBreathe out...");
                Countdown(4);
                elapsed += 8;
            }

            EndActivity();
        }
    }
}
