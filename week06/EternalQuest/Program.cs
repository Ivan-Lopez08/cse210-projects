using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager tracker = new GoalManager();
        int option = 0;

        while (option != 6)
        {

            printMenu(tracker);
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    tracker.CreateGoal();
                    break;
                case 2:
                    tracker.ListGoalDetails();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    tracker.SaveGoals(filename);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string filename1 = Console.ReadLine();
                    tracker.LoadGoals(filename1);
                    break;
                case 5:
                    tracker.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thanks for playing!");
                    break;
                default:
                    Console.WriteLine("Invalid option selected, please try again");
                    break;
            }
        }
    }

    static void printMenu(GoalManager main)
    {
        main.DisplayPlayerInfo();

        Console.WriteLine("\nMenu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}

