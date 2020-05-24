using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Library;
using Task = Library.Task;
using Menu = Library.Menu;
//Используя Windows Forms, разработать игру «Угадай число». 
//Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
//Для ввода данных от человека используется элемент TextBox.
////Ярвимяки Илья

namespace HomeWork.HomeWork7.Task2
{
    class Task2 : Task
    {
        Menu menuArray;
        double x, a, b;
        string test;
        public override string nameTask => "Угадай число";
        public override string discription => "Используя Windows Forms, разработать игру «Угадай число». " +
            "Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. " +
            "Для ввода данных от человека используется элемент TextBox..Для выхода введите пустой символ(Enter)";
        public override void Run()
        {
            Console.WriteLine(discription);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            ExitTask();
        }
    }
}
