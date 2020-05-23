using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//1. 2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив 
//заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
//Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, 
//метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество 
//максимальных элементов. В Main продемонстрировать работу класса.
//Ярвимяки Илья

namespace HomeWork.HomeWork4.Task2
{
    class Task2 : Task
    {
        public override string nameTask => "Операции над массивом";
        public override string discription => "2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, " +
            "создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. " +
            "Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, " +
            "метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, " +
            "возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.";
        MyArray myArray;
        Menu menuArray;
        string titleTask = "";
        public override void Run()
        {
            Console.WriteLine(discription);

            int lengthArray = Parse.StringToInt(InputConsole.GetInputText("Введите размер массива ", true), true);
            int maxValueArray = Parse.StringToInt(InputConsole.GetInputText("Введите максимальное значение массива ", true), true);
            int minValueArray = Parse.StringToInt(InputConsole.GetInputText("Введите минимальное значение массива ", true), true);
            int stepFillArray = Parse.StringToInt(InputConsole.GetInputText("Введите шаг заполнения массива ", true), true);
            stepFillArray = stepFillArray == 0 ? 1 : stepFillArray;
            myArray = new MyArray(lengthArray,minValueArray,maxValueArray, stepFillArray);
            menuArray = new Menu("Был создан массив" + myArray.ToString() + "\n выберите операцию");
            menuArray.menuItems.Clear();
            menuArray.menuItems.Add("Сумма элементов массива", ShowSumArray);
            menuArray.menuItems.Add("Инверсия массива", ShowInverse);
            menuArray.menuItems.Add("Умножение массива", ShowMulti);
            menuArray.menuItems.Add("Максимальные элементы массива", ShowMaxCount);
            menuArray.menuItems.Add("Запись в файл", WriteArrayFile);
            menuArray.menuItems.Add("Чтение из файла", ReadeArrayFile);
            menuArray.OpenMenu("");
            ExitTask();
        }
        void ShowSumArray()
        {
            Console.WriteLine(myArray.Sum);
            Console.ReadLine();
        }
        void ShowInverse()
        {
            myArray.Inverse();
            Console.WriteLine(myArray.ToString());
            Console.ReadLine();
            UpdateTitleTask();
        }
        void ShowMulti()
        {
            int factor = Parse.StringToInt(InputConsole.GetInputText("Введите множитель ", true), true);
            myArray.Multi(factor);
            Console.WriteLine(myArray.ToString());
            Console.ReadLine();
            UpdateTitleTask();
        }
        void ShowMaxCount()
        {
            int factor = Parse.StringToInt(InputConsole.GetInputText("Введите количество выбираемых максимальных чисел ", true), true);
            int[] maxArray = myArray.MaxCount(factor);
            Console.WriteLine(MyArray.ToString(maxArray));
            Console.ReadLine();
        }
        void UpdateTitleTask()
        {
            menuArray.title = "Был созхдан массив " + myArray.ToString() + "\n выберите операцию";
        }
        void WriteArrayFile()
        {
            StreamWriter streamWriter = new StreamWriter("..\\..\\HomeWork4\\Task2\\Array.txt");
            streamWriter.WriteLine(myArray.ToString());
            streamWriter.Close();
            Console.WriteLine("Файл в папке класса task2 ..\\..\\HomeWork4\\Task2\\Array.txt");
            Console.ReadLine();
        }
        void ReadeArrayFile()
        {
            StreamReader streamReader = new StreamReader("..\\..\\HomeWork4\\Task2\\Array.txt");
            string strArray = streamReader.ReadLine();
            Console.WriteLine(strArray);
            Console.ReadLine();
        }
    }
}

    




