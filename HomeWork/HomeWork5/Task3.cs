using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
///3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать:
//а) с использованием методов C#;
//б) * разработав собственный алгоритм.
// Например:
//badc являются перестановкой abcd.
//Ярвимяки Илья

namespace HomeWork.HomeWork5
{
    class Task3 : Task
    {
        public override string nameTask => "Сровнение строк на пеерстановку";
        public override string discription => "Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. " +
            "Регистр можно не учитывать. Для выхода введите пустой символ(Enter)";
        public override void Run()
        {
            Console.WriteLine(discription);
            string word1 = "";
            string word2 = "";
            do
            {
                word1 = InputConsole.GetInputText("Введите первое слово ");
                word2 = InputConsole.GetInputText("Введите второе слово ");
            } while (word1 != "" && !CheckWord(word1, word2));
            ExitTask();
        }
        bool CheckWord(string word1, string word2)
        {
            bool transposition = true;
            if (new Regex($@"[^{word1}]").Matches(word2).Count > 0)
            {
                transposition = false;
            }
            if (SumChars(word1) != SumChars(word2))
            {
                transposition = false;
            }
            if (transposition)
            {
                Console.WriteLine("Второе слово является перестановкой первого");
            }
            else
            {
                Console.WriteLine("Второе слово НЕ является перестановкой первого");
            }
            return transposition;
        }
        int SumChars(string word)
        {
            return word.ToArray().Select(charElem => charElem + 0).Sum();            
        }
    }
}
