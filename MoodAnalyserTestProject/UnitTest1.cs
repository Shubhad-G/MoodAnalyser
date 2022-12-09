using MoodAnalyserDemo_;

namespace MoodAnalyserTestProject
{
    public class Tests
    {
        [Test]
        public void Test1()//test case for happy mood
        {
            string expected = "happy";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.analyseMood("iam happy");//actual output
            Assert.AreEqual(expected, actual);//testing whether the actual output is equal to expected output 
        }
        public void Test2()//test case for sad mood
        {
            string expected = "sad";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.analyseMood("iam sad");//actual output
            Assert.AreEqual(expected, actual);//testing whether the actual output is equal to expected output 
        }
        public void Test3()//test case for any mood
        {
            string expected = "happy";//expected output
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.analyseMood("iam in any mood");//actual output
            Assert.AreEqual(expected, actual);//testing whether the actual output is equal to expected output 
        }
    }
}