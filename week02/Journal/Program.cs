/*
CREATIVITY FEATURES EXCEEDING REQUIREMENTS:
1. Entry counter - shows total entries written (solves "no time" barrier)
2. Empty journal handling - helpful feedback when no entries exist  
3. Formatted display with entry numbers and indentation
4. File existence check before loading (user-friendly)
5. 8 prompts (exceeds minimum 5)
6. Professional menu formatting with ASCII borders
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║           JOURNAL PROGRAM            ║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine("║  1. Write new entry (+{0} total)     ║", journal.EntryCount());
            Console.WriteLine("║  2. Display journal                  ║");
            Console.WriteLine("║  3. Save journal                     ║");
            Console.WriteLine("║  4. Load journal                     ║");
            Console.WriteLine("║  5. Quit                             ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.Write("Enter choice (1-5): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine($"\n📝 PROMPT: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    entry._prompt = prompt;
                    entry._response = response;
                    journal.AddEntry(entry);
                    Console.WriteLine("\n✅ Entry saved!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;

                case "2":
                    journal.Display();
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Enter filename (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.Save(saveFile);
                    Console.WriteLine("✅ Saved successfully!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    journal.Load(loadFile);
                    Console.WriteLine("✅ Loaded successfully!");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;

                case "5":
                    Console.WriteLine("\n👋 Thanks for journaling!");
                    break;

                default:
                    Console.WriteLine("❌ Invalid choice. Please enter 1-5.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        } while (choice != "5");
    }
}
