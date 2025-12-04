using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("7.3", "8-19", "Ivan Lopez", "Fractions");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("The Causes of World War II", "Ivan Lopez", "European History");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}