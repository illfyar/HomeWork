using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Menu
    {
        public delegate void MyDelegate();
        public Dictionary<string, MyDelegate> menuItems = new Dictionary<string, MyDelegate>();
        public string title;

        public Menu()
        {
        }

        public Menu(string title)
        {
            this.title = title;
        }
        public void OpenMenu(string _title = "")
        {
            byte numberTask = 0;
            do
            {
                BeforeFillConsole(_title);
                CreateMenuList();
                numberTask = Parse.StringToByte(InputConsole.GetInputText("Для выхода введите любой символ \nоличный от номера пункта меню: "));
                if (numberTask == 0 || numberTask > menuItems.Count)
                {
                    continue;
                }
                Console.WriteLine(menuItems.ElementAt(numberTask-1).Key);
                MyDelegate runMethod = menuItems.ElementAt(numberTask - 1).Value;
                runMethod();
                Console.ReadLine();
            } while (numberTask != 0 && menuItems.Count >= numberTask);
        }
        public void OpenMenuOnce(string _title = "")
        {
            byte numberTask = 0;
            BeforeFillConsole(_title);
            CreateMenuList();
            numberTask = Parse.StringToByte(InputConsole.GetInputText("Для выхода введите любой символ \nоличный от номера пункта меню: "));
            if (numberTask == 0 || numberTask > menuItems.Count)
            {
                return;
            }
            Console.WriteLine(menuItems.ElementAt(numberTask - 1).Key);
            MyDelegate runMethod = menuItems.ElementAt(numberTask - 1).Value;
            runMethod();
        }
        
        void BeforeFillConsole(string _title)
        {
            Console.Clear();
            if (_title == "")
            {
                Console.WriteLine(title);
            }
            else
            {
                Console.WriteLine(_title);
            }
        }
        void CreateMenuList()
        {
            int i = 0;
            foreach (var item in menuItems)
            {
                i++;
                Console.WriteLine($"{i} - {item.Key}");
            }
        }
        public void CreateMenuList(string[] itemsArray)
        {
            int i = 0;
            foreach (var item in itemsArray)
            {
                i++;
                Console.WriteLine($"{i} - {item}");
            }
        }
    }
}
