using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Library.Task;
//Написать метод подсчета количества цифр числа
//Ярвимяки Илья
namespace HomeWork
{
    namespace HomeWork2
    {
        class Task2 : Task
        {
            public override string nameTask => "Количество цифр числа";
            public override string discription => "Написать метод подсчета количества цифр числа";
            public override void Run()
            {
                Console.WriteLine(discription);
                string str = InputConsole.GetInputText("Введите число: ");
                str = StringMethods.OnlyNumerics(str);
                Console.WriteLine(str.Length);
                ExitTask();
            }
        }
    }
}
