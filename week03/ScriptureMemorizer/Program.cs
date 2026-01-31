/*
Scripture Memorizer
Exceeds core requirements by:
1. Implementing a library of 5 scriptures for random selection
2. Ensuring random word hiding only selects unhid words (stretch challenge)
3. Proper encapsulation with private members and focused class responsibilities
4. Multiple Reference constructors for single verses and ranges
5. Clean console clearing and professional display formatting
*/

using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create scripture library
            List<Scripture> scriptureLibrary = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
                new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."),
                new Scripture(new Reference("Psalm", 23, 1, 3), "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul."),
                new Scripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength. They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint.")
            };

            Random random = new Random();
            Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.\n");

            currentScripture.Display();

            while (!currentScripture.IsCompletelyHidden())
            {
                Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                {
                    Console.WriteLine("\nThanks for memorizing scripture!");
                    return;
                }

                Console.Clear();
                currentScripture.HideRandomWords(2); // Hide 2 random words each time
                currentScripture.Display();
            }

            Console.WriteLine("\nGreat job! You have memorized the entire scripture!");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
