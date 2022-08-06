using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MoodAnalyserProblem
{
    public class MoodAnalyserProblem
    {
        private string message;

        public MoodAnalyserProblem(string message) 
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }

    }
}
