using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork6.Task2
{
    class MinValueFunction
    {
        public delegate double Func(double x);
        public static double XMult2Plus10(double x)
        {
            return x * 2 + 10;
        }
        public static double XMultXMinus50MultXPlus10(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double XPov2MinusX(double x)
        {
            return Math.Pow(x, 2) - x;
        }
        public static void SaveFunc(Func F,string fileName, double x, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double d;
            min = double.MaxValue;
            List<double> listD = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                listD.Add(d);
            }
            bw.Close();
            fs.Close();
            return listD.ToArray();
        }
    }
}
