using System;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t\t\tWelcome To Mood Analyzer Problem!!");
            Console.WriteLine("\t\t\t\t    ----------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            string message = null;
            MoodAnalyserLogic moodAnalyser = new MoodAnalyserLogic(message);
            System.Console.WriteLine("I am in a {0} mood. ",moodAnalyser.AnalyseMood());
            Console.ReadKey();
        }
    }

}
