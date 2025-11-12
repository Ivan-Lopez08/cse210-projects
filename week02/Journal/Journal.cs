using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
        Console.WriteLine("New entry saved! \n");
    }

    public void DisplayAll()
    {
        Console.WriteLine("\nHere are your entries: ");
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        filename += ".txt";

        using (StreamWriter newFile = new StreamWriter(filename))
        {
            newFile.WriteLine("Date|Prompt|Response");

            foreach (Entry entry in _entries)
            {
                string date = entry._date.Replace("\n", " ").Replace("\r", "");
                string prompt = entry._prompt.Replace("\n", " ").Replace("\r", "");
                string response = entry._response.Replace("\n", " ").Replace("\r", "");

                newFile.WriteLine($"{date}|{prompt}|{response}");
            }
        }

        Console.WriteLine($"Journal saved in: {filename}");
    }
    
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"The filename '{filename}' doesn't exists.");
            return;
        }

        _entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                string[] parts = line.Split('|');

                if (parts.Length >= 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2]
                    };

                    _entries.Add(entry);
                }
                else
                {
                    Console.WriteLine($"Wrong format for line: {line}");
                }

            }
        }

        Console.WriteLine("\nJournal loaded successfully! \n");
    }
}