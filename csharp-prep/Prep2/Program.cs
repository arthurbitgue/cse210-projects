using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        double gradePercentage = double.Parse(Console.ReadLine());

        char letter;

        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratiolations, You passed the course! ");
        }
        else
        {
            Console.WriteLine("Don't worry, you can try again next time. ");
        }
    }

}