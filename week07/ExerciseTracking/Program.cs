using System;

class Program
{
    static void Main(string[] args)
    {
        string today = DateTime.Today.ToString("dd MMM yyyy");


        List<Activity> activities = new List<Activity>()
        {
            new Running(today, 30, 4.8),
            new Cycling(today, 45, 20),
            new Swimming(today, 25, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}