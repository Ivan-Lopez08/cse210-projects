using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public Dictionary<int, string> ListGoalNames()
    {
        int count = 1;
        Dictionary<int, string> goalNames = new Dictionary<int, string>();
        Console.WriteLine("The pending goals are: ");
        foreach(Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                Console.WriteLine($"{count}. {goal.GetName()}");
                goalNames.Add(count,goal.GetName());
                count++;
            }
        }

        return goalNames;
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals registered yet...");
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        int type = 0;
        List<string> data = new List<string>();

        Console.WriteLine("The types of goal are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        type = int.Parse(Console.ReadLine());
        data = GetData(type);

        switch (type)
        {
            case 1:
                SimpleGoal newGoalS = new SimpleGoal(data[0], data[1], data[2]);
                _goals.Add(newGoalS);
                break;
            case 2:
                EternalGoal newGoalE = new EternalGoal(data[0], data[1], data[2]);
                _goals.Add(newGoalE);
                break;
            case 3:
                ChecklistGoal newGoalCh = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]));
                _goals.Add(newGoalCh);
                break;
            default:
                Console.WriteLine("Invalid option selected, please try again");
                break;
        }

        static List<string> GetData(int type)
        {
            List<string> rawData = new List<string>();
            Console.Write("What is the name of your goal? ");
            rawData.Add(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            rawData.Add(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            rawData.Add(Console.ReadLine());

            if (type == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                rawData.Add(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                rawData.Add(Console.ReadLine());
            }
            return rawData;
        }
    }

    public void RecordEvent()
    {
        Dictionary<int, string> activeGoals = ListGoalNames();
        if (activeGoals.Count == 0)
        {
            Console.WriteLine("You have no pending Goals");
        }
        else
        {
            Console.Write("Which goal did you accomplish? ");
            int completedGoalId = int.Parse(Console.ReadLine());
            string completedGoalName = activeGoals[completedGoalId];

            foreach (Goal goal in _goals)
            {
                if(goal.GetName() == completedGoalName)
                {
                    _score += goal.RecordEvent();
                    break;
                }
            }
        }
    }

    string GetFilePath(string filename)
    {
        return Path.Combine(AppContext.BaseDirectory, filename);
    }

    public void SaveGoals(string filename)
    {
        string path = GetFilePath(filename);

        using (StreamWriter outputFile = new StreamWriter(path))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name},{goal.GetDetailsString()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string path = GetFilePath(filename);

        bool isFirstLine = true;

        foreach (string line in File.ReadLines(path))
        {
            if (isFirstLine)
        {
            _score = int.Parse(line); 
            isFirstLine = false;   
            continue;              
        }

            string[] data = line.Split(",");

            if (data[0] == "SimpleGoal")
            {
                SimpleGoal newSimple = new SimpleGoal(data[1], data[2], data[3], bool.Parse(data[4]));
                _goals.Add(newSimple);
            }
            else if (data[0] == "EternalGoal")
            {
                EternalGoal newEternal = new EternalGoal(data[1], data[2], data[3]);
                _goals.Add(newEternal);
            }
            else if (data[0] == "ChecklistGoal")
            {
                ChecklistGoal newChecklist = new ChecklistGoal(data[1], data[2], data[3], int.Parse(data[5]), int.Parse(data[4]), int.Parse(data[6]));
                _goals.Add(newChecklist);
            }
        }
    }
}