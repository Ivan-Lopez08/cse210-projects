// Added validation to prevent special characters and verse numbers from being hidden.
// This avoids creating undesired blank spaces and ensures that the character count
// for each word remains consistent.

// Implemented a function that loads a list of scriptures from a .txt file
// and randomly selects one to be used in the mini-game.

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = GetRandomScripture();
        bool end = true;

        while (end)
        {
            if (scripture.IsCompletelyHidden())
            {
                end = false;
            }  
            scripture.GetDisplayText();
            scripture.HideRandomWords(5);
            Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
            string opt = Console.ReadLine();

            if (opt == "quit")
            {
                break;
            }
            Console.Clear();    
        }

    }

    public static Scripture GetRandomScripture()
    {
        List<Scripture> list = new List<Scripture>();
        using (StreamReader reader = new StreamReader("scriptures.txt"))
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

                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                int endVerse = 0;
                if (!string.IsNullOrWhiteSpace(parts[3]))
                {
                    endVerse = int.Parse(parts[3]);
                }
                string text = parts[4];
                Reference reference = new Reference(book, chapter, verse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                
                list.Add(scripture);
            }
        }
        Random random = new Random();
        int randIndex = random.Next(list.Count);

        return list[randIndex];
    }

}