using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
using HomeWork.HomeWork6.Task1;
//2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
//б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
//в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
//возвращает минимум через параметр.
////Ярвимяки Илья

namespace HomeWork.HomeWork6.Task2
{
    class Task2 : Task
    {
        Menu menuList;
        double x, b, h, min;
        public override string nameTask => "Меню функций";
        public override string discription => "Модифицировать программу нахождения минимума функции так, чтобы можно было передавать " +
            "функцию в виде делегата. Для выхода введите пустой символ(Enter)";
        public override void Run()
        {
            menuList = new Menu(discription);
            menuList.menuItems.Clear();
            menuList.menuItems.Add("Вывести x * 2 + 10", ShowXMult2Plus10);
            menuList.menuItems.Add("Вывести  x * x - 50 * x + 10", ShowXMultXMinus50MultXPlus10);
            menuList.menuItems.Add("Вывести Math.Pow(x, 2) - x", ShowXPov2MinusX);
            menuList.OpenMenu("");
            ExitTask();
        }
        void ShowXMult2Plus10()
        {
            InputData();
            MinValueFunction.SaveFunc(MinValueFunction.XMult2Plus10,"Data.txt", x, b, h);
            double[] vs =  MinValueFunction.Load("Data.txt",out min);
            Console.WriteLine(StringMethods.DoubleArrayToString(vs));
            Console.WriteLine($"min = {min}");
        }
        void ShowXMultXMinus50MultXPlus10()
        {
            InputData();
            MinValueFunction.SaveFunc(MinValueFunction.XMultXMinus50MultXPlus10, "Data.txt", x, b, h);
            double[] vs = MinValueFunction.Load("Data.txt", out min);
            Console.WriteLine(StringMethods.DoubleArrayToString(vs));
            Console.WriteLine($"min = {min}");
        }
        void ShowXPov2MinusX()
        {
            InputData();
            MinValueFunction.SaveFunc(MinValueFunction.XPov2MinusX, "Data.txt", x, b, h);
            double[] vs = MinValueFunction.Load("Data.txt", out min);
            Console.WriteLine(StringMethods.DoubleArrayToString(vs));
            Console.WriteLine($"min = {min}");
        }
        void InputData()
        {
            x = Parse.StringToDouble(InputConsole.GetInputText("Введите x: "), true);
            b = Parse.StringToDouble(InputConsole.GetInputText("Введите b(граница): "), true);
            h = Parse.StringToDouble(InputConsole.GetInputText("Введите h(шаг): "), true);
            menuList.title = discription + $"\nx = {x}\nb = {b}\nh = {h}";
        }
    }
}
