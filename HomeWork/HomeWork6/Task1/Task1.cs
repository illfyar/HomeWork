using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). 
//    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
////Ярвимяки Илья

namespace HomeWork.HomeWork6.Task1
{
    class Task1 : Task
    {
        Menu menuArray;
        double x, a, b;
        public override string nameTask => "Функции типа double (double,double).";
        public override string discription => "1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). " +
            "Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x). Для выхода введите пустой символ(Enter)";
        public override void Run()
        {
            Console.WriteLine(discription);
            x = Parse.StringToDouble(InputConsole.GetInputText("Введите x: "), true);
            a = Parse.StringToDouble(InputConsole.GetInputText("Введите a: "), true);
            b = Parse.StringToDouble(InputConsole.GetInputText("Введите b(граница функции): "), true);
            menuArray = new Menu(discription + $"\nx = {x}" + $"\na = {a}" + $"\nb = {b}\n");
            menuArray.menuItems.Clear();
            menuArray.menuItems.Add("Вывести a*x^2", ShowAMultXPow2);
            menuArray.menuItems.Add("Вывести a*sin(x)", ShowAMultSinX);
            menuArray.OpenMenu("");
            ExitTask();
        }       
        void ShowAMultXPow2()
        {
            Functions.Table(Functions.AMultXPow2, x, a, b);
        }
        void ShowAMultSinX()
        {
            Functions.Table(Functions.AMultSinX, x, a, b);
        }
    }
}
