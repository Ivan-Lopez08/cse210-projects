using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        List<Entry> entries = new List<Entry>();
        PromptGenerator Generator = new PromptGenerator();
        Generator.FillPropmtsList();
        Journal journal = new Journal();

        do
        {
            printMenu();
            Console.Write("What would you like to do: ");
            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    string prompt = Generator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string answer = Console.ReadLine();
                    Entry info = new Entry();
                    info._prompt = prompt;
                    info._response = answer;
                    info._date = DateTime.Now.ToString("MM/dd/yyyy");
                    journal.AddEntry(info);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Type the filename of the journal to load it: ");
                    string filename2 = Console.ReadLine();
                    journal.LoadFromFile(filename2);
                    break;
                case 4:
                    Console.Write("Which name do you want to assign to this journal? ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
            }

        } while (option != 5);
    }

    static void printMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the journal program! Please select one of the following choices");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load a journal");
        Console.WriteLine("4. Save the journal");
        Console.WriteLine("5. Quit");
    }
}