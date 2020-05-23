using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Library.Task;
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Ярвимяки Илья
namespace HomeWork
{
    namespace HomeWork2
    {
        class Task3 : Task
        {
            public override string nameTask => "Сумма нечетных положительных чисел";
            public override string discription => "С клавиатуры вводятся числа, пока не будет введен 0. " +
                "Подсчитать сумму всех нечетных положительных чисел.";
            public override void Run()
            {
                Console.WriteLine(discription);
                int userNumb;
                int sumNumb = 0;
                do
                {
                    userNumb = Parse.StringToInt(InputConsole.GetInputText("Введите число: ",true),true);
                    if (userNumb%2 != 0)
                    {
                        sumNumb += userNumb;
                    }
                } while (userNumb != 0);
                Console.WriteLine(sumNumb);
                ExitTask();
            }
        }
    }
}
