using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        double gradePercent = Convert.ToDouble(Console.ReadLine());

        string letter = "";
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        if (letter != "F")
        {
            int lastDigit = (int)(gradePercent % 10);
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        

        string fullGrade = letter + sign;
        Console.WriteLine($"Your grade is: {fullGrade}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard for next time!");
        }
    }
}