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
//а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
////Ярвимяки Илья

namespace HomeWork.HomeWork8.Task1
{
    class Task1 : Task
    {
        Menu menuArray;
        double x, a, b;
        string test;
        public override string nameTask => "Верю не верю";
        public override string discription => "Разработана логика формы игры и добавления вопросов. Для выхода введите пустой символ(Enter)";        
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
