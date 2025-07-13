using System;
class Program
{
    static void Main(string[] args)
    {
        var manager = new HomesteadManager();

        var appleTree = new Tree("Apple Tree", "Zone A");
        var greenhouse = new Structure("Greenhouse", "Zone B");

        manager.AddItem(appleTree);
        manager.AddItem(greenhouse);

        manager.AddTask(new WaterTask("Water the apple tree", DateTime.Now, appleTree));
        manager.AddTask(new BuildTask("Build the greenhouse foundation", DateTime.Now, greenhouse));
        manager.AddTask(new HarvestTask("Harvest apples", DateTime.Now, appleTree, 10));

        manager.UpdateSkill("Grafting", 15);

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("==== Homestead & Orchard Life Manager ====");
            Console.WriteLine("1. Show Scheduled Tasks");
            Console.WriteLine("2. Execute a Task");
            Console.WriteLine("3. Show Overview");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option(1 - 4): ");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("\nScheduled Tasks:");
                    manager.GetPlanner().ShowTasks();
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    var planner = manager.GetPlanner();
                    if (!planner.HasTasks())
                    {
                        Console.WriteLine("\nNo tasks to execute.");
                    }
                    else
                    {
                        Console.WriteLine("\nChoose a task to execute:");
                        planner.ShowTasks();
                        Console.Write("Enter task number: ");
                        if (int.TryParse(Console.ReadLine(), out int choice))
                        {
                            planner.ExecuteTask(choice - 1);
                        }
                    }
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    manager.ShowOverview();
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
