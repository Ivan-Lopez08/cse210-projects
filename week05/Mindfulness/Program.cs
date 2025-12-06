using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOpt = 0;

        while (menuOpt != 4)
        {
            printMenu();
            menuOpt = int.Parse(Console.ReadLine());

            switch (menuOpt)
            {
                case 1:
                    BreathingActivity activityB = new BreathingActivity();
                    activityB.Run();    
                    break;
                case 2:
                    ReflectingActivity activityR = new ReflectingActivity();
                    activityR.Run();
                    break;
                case 3:
                    ListingActivity activityL = new ListingActivity();
                    activityL.Run();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again.");
                    break;
            }
        }
    }

    static void printMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity.");
        Console.WriteLine("2. Start reflecting activity.");
        Console.WriteLine("3. Start listing activity.");
        Console.WriteLine("4. Quit.");
    }
}