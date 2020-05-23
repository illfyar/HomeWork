using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//1. Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита 
//    или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.
//Ярвимяки Илья

namespace HomeWork.HomeWork5
{
    class Task1 : Task
    {
        public override string nameTask => "Проверка корректноси пароля";
        public override string discription => "Создать программу, которая будет проверять корректность ввода логина. " +
            "Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, " +
            "при этом цифра не может быть первой. с использованием регулярных выражений. Для выхода введите пустой символ(Enter)";
        public override void Run()
        {
            Console.WriteLine(discription);
            string userName = "";
            do
            {
                userName = InputConsole.GetInputText("Введите имя пользователя: ");
            } while (!CheckName(userName) && userName != "");
            ExitTask();
        }       
        bool  CheckName(string name)
        {
            bool correctName = true;
            if (new Regex(@"^\d+").Matches(name).Count > 0)
            {
                Console.WriteLine("Запрещено использовать цифры в начале имени пользователя");
                correctName = false;
            }
            if (new Regex(@"^(.{0,2}|.{11,})$").Matches(name).Count > 0)
            {
                Console.WriteLine("Длина имени пользователя должна быть не меньше 2 и не больше 10 символов");
                correctName = false;
            }
            if (new Regex(@"[^a-zA-Z0-9]").Matches(name).Count > 0)
            {
                Console.WriteLine("Имя пользователя должно состоять только из букв латинского алфавита и цифр ");
                correctName = false;
            }
            if (correctName)
            {
                Console.WriteLine("Имя пользователя корректно");
            }
            return correctName;
        }
    }
}
