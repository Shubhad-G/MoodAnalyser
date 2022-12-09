using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo_
{
    public class MoodAnalyser//made the class as public so that the test project can have the access to create the object and test it
    {
        string message;
        public MoodAnalyser(string message)//parameterised constructor
        {
            this.message = message;
        }
        public MoodAnalyser()//default constructor
        {

        }

        public string analyseMood()
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
