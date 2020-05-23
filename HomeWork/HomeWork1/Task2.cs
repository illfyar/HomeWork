using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.InputConsole;
using Task = Library.Task;
/*2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
где m — масса тела в килограммах, h — рост в метрах.
Ярвимяки Илья*/
namespace HomeWork
{
    namespace HomeWork1
    {
        class Task2 : Task
        {
            public override string nameTask => "Индекс массы тела";
            public override string discription => "Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h)";
            public override void Run()
            {
                Console.WriteLine(discription);
                string heightStr = GetInputText("Укажите Ваш рост: ");
                string massStr = GetInputText("Укажите Ваш вес: ");

                byte height, mass;
                height = byte.TryParse(heightStr, out height) ? height : (byte)0;
                mass = byte.TryParse(massStr, out mass) ? mass : (byte)0;

                float bmi = (float)mass / (height * height);

                Console.WriteLine($"Ваш индекс массы тела равен: {bmi}");

                ExitTask();
            }
        }
    }
}
