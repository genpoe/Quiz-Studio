using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        string questionText;
        Dictionary<string, double> answers;
        double points;

        public Question(string questionText, Dictionary<string, double> answers, double points)
        {
            this.questionText = questionText;
            this.answers = answers;
            this.points = points;
        }
    }
}
