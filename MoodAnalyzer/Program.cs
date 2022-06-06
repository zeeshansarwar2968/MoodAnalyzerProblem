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
            //try-catch block code to run and catch any exceptions
            try
            {
                string message = string.Empty;
                MoodAnalyserLogic moodAnalyser = new MoodAnalyserLogic(message);
                string result = moodAnalyser.AnalyseMood();
                Console.WriteLine(result);
            }
            catch (MoodAnalyserException m)
            {

                Console.WriteLine(m.Message); ;
            }
            
            Console.ReadKey();
        }
    }

}
