using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork4.Task2
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el 
        public int Sum { get => a.Sum(); }
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        //  Создание массива и заполнение его случайными числами от min до max с шагом step
        public MyArray(int n, int min, int max, int step)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i+= step)
                a[i] = rnd.Next(min, max);
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        public static string ToString(int[] array)
        {
            string s = "";
            foreach (int v in array)
                s = s + v + " ";
            return s;
        }
        public void Inverse()
        {
            a = a.Select(elem => elem * -1).ToArray();
        }
        public void Multi(int x)
        {
            a = a.Select(elem => elem * x).ToArray();
        }
        public int[] MaxCount(int count)
        {
            ArrayList returnArray = new ArrayList();
            int[] copyA = new int[a.Length];
            a.CopyTo(copyA,0);
            Array.Sort(copyA);

            int i = 1;
            int max = 0;
            int min = copyA.Min();
            while (i <= count)
            {
                max = copyA.Max();
                returnArray.Add(max);
                copyA.SetValue(min, Array.IndexOf(copyA, max));
                i++;
            }
            return (int[]) returnArray.ToArray(typeof(int));            
        }
    }
}
