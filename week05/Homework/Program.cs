class Program
{
    static void Main(string[] args)
    {
        // Test Base Assignment
        Console.WriteLine("=== Base Assignment ===");
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        // Output: Samuel Bennett - Multiplication

        // Test MathAssignment (inherits + adds)
        Console.WriteLine("\n=== Math Assignment ===");
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());           // Inherited method
        Console.WriteLine(math.GetHomeworkList());      // New method
        // Output: 
        // Roberto Rodriguez - Fractions
        // Section 7.3 Problems 8-19

        // Test WritingAssignment (inherits + adds)
        Console.WriteLine("\n=== Writing Assignment ===");
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());              // Inherited method
        Console.WriteLine(writing.GetWritingInformation());   // New method
        // Output:
        // Mary Waters - European History
        // The Causes of World War II by Mary Waters
    }
}
