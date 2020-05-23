using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//Написать метод, возвращающий минимальное из трёх чисел.
//Ярвимяки Илья
namespace HomeWork
{
    namespace HomeWork2
    {
        class Task1 : Task
        {
            public override string nameTask => "Минимальное число из трех";
            public override string discription => "Написать метод, возвращающий минимальное из трёх чисел";

            public override void Run()
            {
                Console.WriteLine(discription);
                float[] arrayNumbers = new float[3];
                for (int i = 0; i < 3; i++)
                {
                    arrayNumbers[i] = Parse.StringToFloat(InputConsole.GetInputText($"Введите {i+1} число: "), true);
                }
                Console.WriteLine(arrayNumbers.Min());
                ExitTask();
            }
        }
    }
}

