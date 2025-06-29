class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option(1-7): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: "); string name = Console.ReadLine();
                    Console.Write("Description: "); string desc = Console.ReadLine();
                    Console.Write("Points: "); int pts = int.Parse(Console.ReadLine());

                    if (type == "1") manager.AddGoal(new SimpleGoal(name, desc, pts));
                    else if (type == "2") manager.AddGoal(new EternalGoal(name, desc, pts));
                    else if (type == "3")
                    {
                        Console.Write("Target count: "); int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: "); int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                    }
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    manager.DisplayGoals();
                    Console.Write("Which goal did you complete? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;

                case "4":
                    manager.DisplayScore();
                    break;

                case "5":
                    Console.Write("Filename to save: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case "6":
                    Console.Write("Filename to load: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "7":
                    return;
            }
        }
    }
}