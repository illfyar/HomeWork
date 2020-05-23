using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Library.Task;
//Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
//«Хорошим» называется число, которое делится на сумму своих цифр. 
//Ярвимяки Илья
namespace HomeWork
{
    namespace HomeWork2
    {
        class Task4 : Task
        {
            public override string nameTask => "Количество хороших чисел";
            public override string discription => "Написать программу подсчета количества «хороших» " +
                "чисел в диапазоне от 1 до 1 000 000 000. " +
                "«Хорошим» называется число, которое делится на сумму своих цифр. ";
            public override void Run()
            {
                Console.WriteLine(discription);
                string userString;
                int userNumb = 1;
                int countGN = 0;
                do
                {
                    int sumNum = 0;
                    userString = InputConsole.GetInputText("Введите число: ", true);
                    if (userString == "")
                    {
                        continue;
                    }
                    userNumb = Parse.StringToInt(userString, true);
                    int[] arrayInt = Array.ConvertAll(userString.ToArray(), elem => elem - '0');
                    sumNum = arrayInt.Sum();
                    if (userNumb !=0 && userNumb % sumNum == 0)
                    {
                        countGN ++;
                    }
                } while (userNumb != 0);
                Console.WriteLine(countGN);
                ExitTask();
            }
        }
    }
}
