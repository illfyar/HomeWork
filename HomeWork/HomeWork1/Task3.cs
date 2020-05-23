using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.InputConsole;
using Task = Library.Task;
/*3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор
формата .2f(с двумя знаками после запятой);
б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
Ярвимяки Илья*/
namespace HomeWork
{
    namespace HomeWork1
    {
        class Task3 : Task
        {
            public override string nameTask => "Растояние между точками";
            public override string discription => "*3.	а)Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2" + 
                "по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор" + 
                "формата .2f(с двумя знаками после запятой);" + 
                 "б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.";
            public override void Run()
            {
                Console.WriteLine(discription);
                string x1Str = GetInputText("Укажите x1: ");
                string y1Str = GetInputText("Укажите y1: ");
                string x2Str = GetInputText("Укажите x2: ");
                string y2Str = GetInputText("Укажите y2: ");

                double x1, x2, y1, y2, distance;
                x1 = double.TryParse(x1Str, out x1) ? x1 : (double)0;
                y1 = double.TryParse(y1Str, out y1) ? y1 : (double)0;
                x2 = double.TryParse(x2Str, out x2) ? x2 : (double)0;
                y2 = double.TryParse(y2Str, out y2) ? y2 : (double)0;

                distance = CalculateDistance(x1, y1, x2, y2);

                Console.WriteLine($"Растояние межту точками = {distance:f2}");
                ExitTask();
            }
            private static double CalculateDistance(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
        }
    }
}
