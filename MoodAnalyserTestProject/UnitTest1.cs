using MoodAnalyserDemo_;

namespace MoodAnalyserTestProject
{
    public class Tests
    {
        [Test]
        public void Test1()//test case for happy mood
        {
            string expected = "happy";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser("iam happy");
            string actual = moodAnalyser.analyseMood();//actual output
            Assert.AreEqual(expected, actual);//testing whether the actual output is equal to expected output 
        }
        public void Test2()//test case for sad mood
        {
            string expected = "sad";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser("iam sad");
            string actual = moodAnalyser.analyseMood();//actual output
            Assert.AreEqual(expected, actual);//testing whether the actual output is equal to expected output 
        }
        public void Test3()//test case for any mood
        {
            string expected = "happy";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser("iam in any mood");
            string actual = moodAnalyser.analyseMood();//actual output
            Assert.AreEqual(expected, actual);//testing whether the actual output is equal to expected output 
        }

        public void Test4()//test case for null reference cutom made exception
        {
            string expected = "happy";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string actual = moodAnalyser.analyseMood();//actual output
            Assert.AreEqual(expected , actual);//testing whether the actual output is equal to expected output
        }

    }
}