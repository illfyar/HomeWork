using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class InputConsole
    {
        public static void OutputText(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
        public static string GetInputText(string text, bool onlyNumeric = false)
        {
            Console.Write(text);
            if (onlyNumeric)
            {
                return StringMethods.OnlyNumerics(Console.ReadLine());
            }
            return Console.ReadLine();
        }
        public static string GetInputText(string text, int x, int y, bool onlyNumeric = false)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
            if (onlyNumeric)
            {
                return StringMethods.OnlyNumerics(Console.ReadLine());
            }
            return Console.ReadLine();
        }
    }
}
