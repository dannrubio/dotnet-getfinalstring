using System;

class Program
{
    static void Main()
    {
        Console.Write("Source:  ");
        string sourceString = Console.ReadLine()?.ToUpper() ?? string.Empty;

        Console.Write("Target:  ");
        string targetString = Console.ReadLine()?.ToUpper() ?? string.Empty;

        if (string.IsNullOrEmpty(sourceString) || string.IsNullOrEmpty(targetString))
        {
            Console.WriteLine("Source or target string was empty. Exiting.");
            return;
        }

        var processor = new StringProcessor(targetString);
        string finalString = processor.GetFinalString(sourceString);

        Console.Write($"\n Final:  {finalString}");
    }
}
