using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo_
{
    public class MoodAnalyserCustomException : Exception
    {
        public MoodAnalyserCustomException(string message) : base(message)
        {
            
        }
    }
}
