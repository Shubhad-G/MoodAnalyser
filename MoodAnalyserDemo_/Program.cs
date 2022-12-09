using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood analyser program");
            MoodAnalyser moodAnalyser = new MoodAnalyser("iam in any  mood");
            string mood =moodAnalyser.analyseMood();
            Console.WriteLine("mood:{0}",mood);
            Console.ReadLine();
        }
    }
}
