using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserLogic
    {
        public string message;

        //non parameterized/default constructor, invoked when there is no input parameter
        public MoodAnalyserLogic()
        {
            this.message = "";
        }
        //parameterized constructor, invoked when there is input parameter
        public MoodAnalyserLogic(string message)
        {
            this.message = message;
        }
        
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Message should not be empty");
                }
                //This method is used to check whether the substring occurs within a given string or not
                else if (this.message.Contains("sad", StringComparison.OrdinalIgnoreCase))  //this performs a case-insensitive ordinal string comparison
                    return "SAD";
                
                else
                    return "HAPPY";  //default return value 

            }
            catch(NullReferenceException)
            {

                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE,"Message should not be null") ;
            }
            
        }
    }
}
