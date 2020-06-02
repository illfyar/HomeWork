using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork8
{
    public struct Question
    {
        public int NumberQuestion { get; set; }
        public string QuestionText { get; set; }
        public StatusesAnswer Truth { get; set; }
        public StatusesAnswer UserAnswer { get; set; }
        public Question(string questionText, StatusesAnswer truth, StatusesAnswer userAnswer, int numberQuestion)
        {
            QuestionText = questionText;
            Truth = truth;
            NumberQuestion = numberQuestion;
            UserAnswer = userAnswer;
        }
    }
}
