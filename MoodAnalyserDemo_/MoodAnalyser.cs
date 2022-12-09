using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo_
{
    public class MoodAnalyser//made the class as public so that the test project can have the access to create the object and test it
    {
        public string analyseMood(string message)
        {
            if (message.ToLower().Contains("happy"))
                return "happy";
            else if (message.ToLower().Contains("sad"))
                return "sad";
            else
                return "happy";
        }
    }
}
