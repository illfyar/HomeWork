using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
//Ярвимяки Илья

namespace HomeWork.HomeWork3.Task1
{
    class Task1 : Task
    {
        public override string nameTask => "Комплексные числа";
        public override string discription => "а) Дописать структуру Complex, добавив метод " +
            "вычитания комплексных чисел.Продемонстрировать работу структуры.\n" + 
            "б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.\n" + 
            "в) Добавить диалог с использованием switch демонстрирующий работу класса.";
        public override void Run()
        {
            Console.WriteLine(discription);
            Console.WriteLine("Создание первого комплексного числа");
            Complex comNum1 = CreateComplex();
            Console.WriteLine("Создание второго комплексного числа");
            Complex comNum2 = CreateComplex();
            string[] arrayItemsMenu = new string[3] 
            { "Сложение комплексных чисел", "Вычитание комплексных чисел", "Умножение комплексных чисел" };
            Menu menu = new Menu();
            byte numberTask = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите операцию над числами");
                menu.CreateMenuList(arrayItemsMenu);
                numberTask = Parse.StringToByte(InputConsole.GetInputText("Для выхода введите любой символ \nоличный от номера пункта меню: "));
                if (numberTask == 0 || numberTask > arrayItemsMenu.Length)
                {
                    continue;
                }
                switch (numberTask)
                {
                    case 1:
                        Complex comNumPlus = comNum1.Plus(comNum2);
                        Console.WriteLine(comNumPlus.ToString());
                        break;
                    case 2:
                        Complex comNumMinus = comNum1.Minus(comNum2);
                        Console.WriteLine(comNumMinus.ToString());
                        break;
                    case 3:
                        Complex comNumProduct = comNum1.Product(comNum2);
                        Console.WriteLine(comNumProduct.ToString());
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            } while (numberTask != 0 && arrayItemsMenu.Length >= numberTask);

            ExitTask();
        }
        Complex CreateComplex()
        {
            double re = Parse.StringToDouble(InputConsole.GetInputText("Введите действительное число: ", true),true);
            double im = Parse.StringToDouble(InputConsole.GetInputText("Введите мнимое число: ", true), true);
            return new Complex(im, re);
        }
        }
}
