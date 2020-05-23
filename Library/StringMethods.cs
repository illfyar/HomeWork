using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class StringMethods
    {
        public static string OnlyNumerics(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ((str[i] < '0' || str[i] > '9')&& str[i] != '-') {
                    str = str.Remove(i);
                }
            }
            return str;
        }
        public static string IntArrayToString(int[] array)
        {
            string s = "";
            foreach (int v in array)
                s = s == "" ? v + "" : s += " " + v;
            return s;
        }
        public static string DoubleArrayToString(double[] array)
        {
            string s = "";
            foreach (double v in array)
                s = s == ""? v + "" : s += " " +  v ;
            return s;
        }
    }
}
