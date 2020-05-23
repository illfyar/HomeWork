using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, 
//для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
//Ярвимяки Илья

namespace HomeWork.HomeWork4
{
    class Task1 : Task
    {
        public override string nameTask => "Пары элементов массиваб, в которых хотя бы одно число делится на 3";
        public override string discription => "1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать " +
            "целые значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество " +
            "пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается " +
            "два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4." +
            "Для окончания заполнения массива нажмите Enter";
        public override void Run()
        {
            Console.WriteLine(discription);
            short[] numbArray = CreateArray();
            ushort sumCouple = 0;
            for (int i = 0; i < numbArray.Length - 1; i++)
            {
                if (FindOddInCouple(numbArray[i], numbArray[i + 1]))
                {
                    sumCouple++;
                }
            }
            Console.WriteLine(sumCouple);
            ExitTask();
        }

        private bool FindOddInCouple(short v1, short v2)
        {
            return v1 % 3 == 0 || v2 % 3 == 0;
        }

        private short[] CreateArray()
        {
            ArrayList userNumbers = new ArrayList();
            string userNumb = "";
            do
            {
                userNumb = InputConsole.GetInputText("", true);
                if (userNumb == "")
                {
                    continue;
                }
                userNumbers.Add(Parse.StringToShort(userNumb,true));
            } while (userNumb != "");
            short[] returArray = (short[]) userNumbers.ToArray(typeof(short));
            return returArray;
        }
    }
}
