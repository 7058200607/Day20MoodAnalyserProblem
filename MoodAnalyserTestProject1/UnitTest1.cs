using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserTestProject1;
using Day20MoodAnalyserProblem;

namespace MoodAnalyserTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        private static void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = "I am In Sad Mood";
            AMoodAnalyser moodAnalyser = new AMoodAnalyser(message);
            var mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}