using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечётных положительных чисел.
//Сами числа и сумму вывести на экран, используя tryParse.
//Ярвимяки Илья

namespace HomeWork.HomeWork3.Task2
{
    class Task2 : Task
    {
        public override string nameTask => "Сложение нечетных чисел";
        public override string discription => "С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). " +
            "Требуется подсчитать сумму всех нечётных положительных чисел. " +
            "Сами числа и сумму вывести на экран, используя tryParse.";
        public override void Run()
        {
            Console.WriteLine(discription);
            int number = 0;
            int sum = 0;
            string numAtSum = "";
            string numberStr = "";
            do
            {
                numberStr = InputConsole.GetInputText("", true);
                number = Parse.StringToInt(numberStr, true);//tryParse используется в этом методе
                if (number > 0 && number%2 != 0)
                {
                    numAtSum = numAtSum == "" ? numberStr : numAtSum + "," + numberStr;
                    sum += number;
                }
            } while (number !=0);
            Console.WriteLine($"Сумма чисел = {sum}");
            Console.WriteLine($"Слагаемые числа: {numAtSum}");
            ExitTask();
        }
        }
}
