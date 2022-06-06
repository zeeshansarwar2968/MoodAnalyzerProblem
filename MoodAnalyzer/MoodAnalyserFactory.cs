using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        //static method --> return type id an object
        public static object CreateMoodAnalyserObject(string className, string constructorName)
        {
            //Expression to validate the constructor name
            string pattern = @"." + constructorName + "$";

            Match result = Regex.Match(className, pattern);

            if (result.Success) //returns a bool value
            {
                try
                {
                    //invoking assembly methods to fetch the current execution assembly
                    Assembly executing = Assembly.GetExecutingAssembly();
                    //getting the type object specified in the assembly instance
                    Type moodAnalyseType = executing.GetType(className);

                    //returning an instance of the specified type
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_AVAILABLE_CLASS, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_AVAILABLE_METHOD, "constructor not found");
            }
        }


        
    }
}