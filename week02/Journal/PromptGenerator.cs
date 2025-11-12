public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void FillPropmtsList()
    {
        string filename = "questionPrompts.txt";
        _prompts = new List<string>(System.IO.File.ReadAllLines(filename));
    }
    
    public string GetRandomPrompt()
    {
        Random randomNum = new Random();
        int num = randomNum.Next(0, _prompts.Count);
        string prompt = _prompts[num];

        return prompt;
    }
}