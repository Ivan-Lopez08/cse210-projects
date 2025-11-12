public class Entry()
{
    public string _prompt;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Question: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
    }

}