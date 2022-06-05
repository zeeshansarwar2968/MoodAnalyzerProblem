using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserException : Exception
    {
        //creating enum to store different types of errors
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE
        }

        //declaring a readonly variable
        public readonly ExceptionType Type;
        public MoodAnalyserException(ExceptionType type, string message): base(message)
        {
            this.Type = type;
        }
    }
}
