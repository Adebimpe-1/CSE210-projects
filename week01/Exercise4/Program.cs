using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            numbers.Add(num);
        }

        double sum = 0;
        foreach (double n in numbers)
        {
            sum += n;
        }

        double average = sum / numbers.Count;
        double max = double.MinValue;
        foreach (double n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        double minPositive = double.MaxValue;
        bool hasPositive = false;
        foreach (double n in numbers)
        {
            if (n > 0 && n < minPositive)
            {
                minPositive = n;
                hasPositive = true;
            }
        }

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (hasPositive)
        {
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }

        Console.Write("The sorted list is: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Count - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}