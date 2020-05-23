using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.InputConsole;
using Task = Library.Task;
/*1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
 В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
Ярвимяки Илья*/
namespace HomeWork
{
    namespace HomeWork1 
    { 
    class Task1 : Task
        {
            public override string nameTask => "Анкета";
            public override string discription => "Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес)";
            public override void Run()
            {
            Console.WriteLine(discription);
            string firstName = GetInputText("Укажите Ваше имя: ");
            string lastName = GetInputText("Укажите Вашу фамилию: ");
            string ageStr = GetInputText("Укажите Ваш возраст: ");
            string heightStr = GetInputText("Укажите Ваш рост: ");
            string weightStr = GetInputText("Укажите Ваш вес: ");
            
            byte age, height, weight;
            age = byte.TryParse(ageStr, out age) ? age : (byte) 0;
            height = byte.TryParse(heightStr, out height) ? height : (byte)0;
            weight = byte.TryParse(weightStr, out weight) ? weight : (byte)0;

            Console.WriteLine("Вы указали следующие данные:" +
                " Имя: " + firstName + " Фамилия: " + lastName + 
                "\nВозраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Вы указали следующие данные (форматированный вывод):" +
                 " Имя: {0} Фамилия: {1}"  + 
                 "\nВозраст: {2:C} Рост: {3:X4} Вес: {4:F5}",firstName,lastName,age,height,weight);
            Console.WriteLine("Вы указали следующие данные (вывод $): + " +
                $" Имя: {firstName} Фамилия: {lastName}" +
                 $"\nВозраст: {age:C} Рост: {height:X4} Вес: {weight:F5}");
                ExitTask();
        }
    }
        
    }
}
