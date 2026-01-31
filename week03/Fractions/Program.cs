// File: Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Using no-arg constructor -> 1/1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // 1/1
        // Show current top/bottom via getters
        Console.WriteLine(f1.GetTop());    // 1
        Console.WriteLine(f1.GetBottom()); // 1

        // Using one-arg constructor -> top/1
        Fraction f2 = new Fraction(5); // 5/1
        Console.WriteLine(f2.GetFractionString()); // 5/1
        Console.WriteLine(f2.GetTop());    // 5
        Console.WriteLine(f2.GetBottom()); // 1

        // Using two-arg constructor -> top/bottom
        Fraction f3 = new Fraction(6, 7); // 6/7
        Console.WriteLine(f3.GetFractionString()); // 6/7
        Console.WriteLine(f3.GetDecimalValue());  // 0.8571428571428571 (example)

        // Demonstrate setters
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString()); // 3/4
        Console.WriteLine(f3.GetDecimalValue());  // 0.75

        // Additional samples just like the prompt
        Fraction a = new Fraction(1, 1);
        Console.WriteLine(a.GetFractionString()); // 1/1
        Console.WriteLine(a.GetDecimalValue());  // 1.0

        Fraction b = new Fraction(1, 3);
        Console.WriteLine(b.GetFractionString()); // 1/3
        Console.WriteLine(b.GetDecimalValue());  // 0.3333333333333333

        // Pause so you can see output when running from some environments
        // Console.ReadLine();
    }
}