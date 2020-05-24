using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork7.Task2
{
    enum Positions { over, less, equally, undefined };
    class GuessNumberGame
    {
        public int CounAttempt { get; set; } = 0;
        public Positions Position { get; set; } = Positions.undefined;
        //bool Over { get; set; } = true;
        int QuessedNumber { get; set; } = 101;
        public List<string> History { get; set; } = new List<string>();

        public GuessNumberGame()
        {
            Random random = new Random();
            QuessedNumber = random.Next(0, 100);
            History.Add("Было загадано число от 0 до 100, попробуйте отгадать");
        }
        public void CheckAnswer(string userAnswer)
        {
            if (! Int32.TryParse(userAnswer, out int number))
            {
                History.Add("Данные введены не правильно. Введите число от 1 до 100");
                Position = Positions.undefined;
                return;
            }
            if (number == QuessedNumber)
            {
                History.Add("Ответ правильный, Вы выйграли.");
                Position = Positions.equally;
            }else if(number < QuessedNumber)
            {
                History.Add("Загаданное число больше.");
                Position = Positions.over;
                CounAttempt += 1;
            }
            else if (number > QuessedNumber)
            {
                History.Add("Загаданное число меньше.");
                Position = Positions.less;
                CounAttempt += 1;
            }
        }
    }
}
