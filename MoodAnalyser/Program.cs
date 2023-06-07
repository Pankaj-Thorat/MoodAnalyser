using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a MoodAnalyser object
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            // Call the AnalyseMood function with a message
            string message = "I am feeling happy today!";
            string mood = moodAnalyser.AnalyseMood(message);

            string message1 = "I am feeling sad today!";
            string mood1 = moodAnalyser.AnalyseMood(message1);

            string message2 = "I am feeling nothing today!";
            string mood2 = moodAnalyser.AnalyseMood(message2);

            // Print the determined mood
            Console.WriteLine("Mood: " + mood);//happy
            Console.WriteLine("Mood: " + mood1);//sad
            Console.WriteLine("Mood: " + mood2);//happy
        }
    }
}
