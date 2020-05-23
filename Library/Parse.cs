using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Parse
    {
        public static float StringToFloat(String str, bool check = false)
        {
            float result = float.TryParse(str, out result) ? result : (float)0;
            if (check && result == 0 && str != "0")
            {
                Console.WriteLine("Некорректные данные, результат равен 0");
            }
            return result;
        }
        public static int StringToInt(String str, bool check = false)
        {
            int result = Int32.TryParse(str, out result) ? result : 0;
            if (check && result == 0 && str != "0")
            {
                Console.WriteLine("Некорректные данные, результат равен 0");
            }
            return result;
        }
        public static short StringToShort(String str, bool check = false)
        {
            short result = Int16.TryParse(str, out result) ? result : (short) 0;
            if (check && result == 0 && str != "0")
            {
                Console.WriteLine("Некорректные данные, результат равен 0");
            }
            return result;
        }
        public static byte StringToByte(String str, bool check = false)
        {
            byte result = byte.TryParse(str, out result) ? result : (byte)0;
            if (check && result == 0 && str != "0")
            {
                Console.WriteLine("Некорректные данные, результат равен 0");
            }
            return result;
        }
        public static double StringToDouble(String str,bool check = false)
        {
            double result = double.TryParse(str, out result) ? result : (double)0;
            if (check && result == 0.0 && str != "0")
            {
                Console.WriteLine("Некорректные данные, результат равен 0");
            }
            return result;
        }
    }
}
