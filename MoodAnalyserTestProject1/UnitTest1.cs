using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserTestProject1;
using Day20MoodAnalyserProblem;

namespace MoodAnalyserTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMethod1()
        {
        }
        [TestMethod]
        private static void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = "I am In Sad Mood";
            AMoodAnalyser moodAnalyser = new AMoodAnalyser(message);
            var mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            string expected = "Happy";
            AMoodAnalyser moodAnalyser = new AMoodAnalyser(message);
            var mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}