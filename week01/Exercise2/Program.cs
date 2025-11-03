using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        char gradeLetter;
        char sign = ' ';

        if (grade >= 90)
        {
            gradeLetter = 'A';
        }
        else if (grade >= 80)
        {
            gradeLetter = 'B';
        }
        else if (grade >= 70)
        {
            gradeLetter = 'C';
        }
        else if (grade >= 60)
        {
            gradeLetter = 'D';
        }
        else
        {
            gradeLetter = 'F';
        }

        if ((grade % 10) >= 7 && gradeLetter != 'A' && gradeLetter != 'F')
        {
            sign = '+';
        }
        else if ((grade % 10) < 3 && gradeLetter != 'F')
        {
            sign = '-';
        }

        if (grade > 70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a {gradeLetter}{sign}");
        }
        else
        {
            Console.WriteLine($"It was a good try but you got an {gradeLetter}, good luck next time");
        }

    }
}