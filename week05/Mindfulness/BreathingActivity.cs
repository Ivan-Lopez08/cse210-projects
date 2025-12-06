public class BreathingActivity : Activity
{

    public BreathingActivity(
        string name = "Breathing Activity",
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        int duration = 30
        ) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}