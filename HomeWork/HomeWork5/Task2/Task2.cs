using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//2. Разработать класс Message, содержащий следующие статические методы для обработки
//текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//Продемонстрируйте работу программы на текстовом файле с вашей программой.
//Ярвимяки Илья

namespace HomeWork.HomeWork5.Task2
{
    class Task2 : Task
    {
        Message Message;
        Menu menuArray;
        public override string nameTask => "Класс Message";
        public override string discription => "Для выхода введите пустой символ(Enter) \n" +
            "Разработать класс Message, содержащий следующие статические методы для обработки текста: ";
        public override void Run()
        {
            menuArray = new Menu(discription);
            menuArray.menuItems.Clear();
            menuArray.menuItems.Add("Ввести строку с клавиатуры", WriteUserString);
            menuArray.menuItems.Add("Загрузить строку из файла", WriteUserStringReadFromFile);
            menuArray.OpenMenuOnce();
            menuArray.menuItems.Clear();
            menuArray.menuItems.Add("Вывести слова определенной длины", WordsCertainLength);
            menuArray.menuItems.Add("Удалить слова начинающиесся на", DeleteWordsStartingWith);
            menuArray.menuItems.Add("Вывести слово максимальной длины", MaxWord);
            menuArray.menuItems.Add("Вывести строку из максимальных строк", LongestWords);
            menuArray.menuItems.Add("Записать в файл", WriteInFileUserString);
            menuArray.OpenMenu("");

            ExitTask();
        }
        void WriteUserString()
        {
            Message = new Message();
            Message.UserString = InputConsole.GetInputText("Введите строку: ");
        }
        void WriteUserStringReadFromFile()
        {
            Message = new Message();
            string path = InputConsole.GetInputText("Введите путь к фалу(0 - файл по умолчанию): ");
            if (path == "0")
            {
                Message.ReadFile("..\\..\\HomeWork5\\Task2\\Data.txt");
            }
            else
            {
                Message.ReadFile(path);
            }
        }
        void WordsCertainLength()
        {
            int length = Parse.StringToInt(InputConsole.GetInputText("Введите длину слова: ",true), true);
            Console.WriteLine(Message.WordsCertainLength(length));
            Console.ReadLine();
        }
        void DeleteWordsStartingWith()
        {
            string str = InputConsole.GetInputText("Введите начало слова: ");
            Message.DeleteWordsStartingWith(str);
            Console.WriteLine(Message.UserString);
            Console.ReadLine();
        }
        void MaxWord()
        {
            Console.WriteLine(Message.MaxWord());
            Console.ReadLine();
        }
        void LongestWords()
        {
            int count = Parse.StringToInt(InputConsole.GetInputText("Введите количество слов ", true), true);
            Console.WriteLine(Message.LongestWords(count));
            Console.ReadLine();
        }
        void WriteInFileUserString()
        {
            string path = InputConsole.GetInputText("Введите путь к фалу(0 - файл по умолчанию): ");
            if (path == "0")
            {
                Message.WriteToFile("..\\..\\HomeWork5\\Task2\\Data.txt");
            }
            else
            {
                Message.WriteToFile(path);
            }
        }

    }
}
