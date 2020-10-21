using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Quiz
{
    public class Question
    {
        public string questionText;
        public Dictionary<char, string> answers;
        public double points;
        public char correctAnswer;

        public Question(string questionText, Dictionary<char, string> answers, double points, char correctAnswer)
        {
            this.questionText = questionText;
            this.answers = answers;
            this.points = points;
            this.correctAnswer = correctAnswer;
        }

        public void printQuestion()
        {
            Console.WriteLine(this.questionText);
            foreach (KeyValuePair<char, string> answer in answers)
            {
                Console.WriteLine(answer.Key + ": " + answer.Value);
            }
        }

        public double GetPoints(char answer)
        {
            if (answer == correctAnswer)
            {
                return this.points;
            }
            return 0;
        }

    }
}
