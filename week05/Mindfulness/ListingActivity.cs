public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(
        string name = "Listing Activity",
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        int duration = 30
        ) : base(name, description, duration)
    {
        _count = 0;
        _prompts = File.ReadAllLines("listingPrompts.txt").ToList();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            GetListItemFromUser();
            _count ++;
        }

        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }

    public void GetListItemFromUser()
    {
        Console.Write("> ");
        Console.ReadLine();
    }
}