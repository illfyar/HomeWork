using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork6.Task1
{
    public class Functions
    {
        public delegate double Fun(double x);
        public delegate double Fun2D(double x, double y);
        // Создаем метод, который принимает делегат
        // То есть на практике, этот метод сможет принимать любой метод
        // с такой же сигнатурой как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static void Table(Fun2D F, double x, double a, double b)
        {
            Console.WriteLine("---- X ---- A ----- Y");
            while (x <= b)
            {
                Console.WriteLine("| {0:0.000} | {1:0.000} | {2:0.000} |", x,a, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        public static double AMultXPow2(double a, double x)
        {
            return a * Math.Pow(x,2);
        }
        public static double AMultSinX(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
