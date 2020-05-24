using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace HomeWork
{
    public partial class CreateListHomeWork
    {
        Menu mainMenu = new Menu("Выбирите домашнюю работу");
        Menu taskMenu = new Menu();        

        public void OpenMenu()
        {
            mainMenu.OpenMenu();
        }
        public CreateListHomeWork() 
        {
            mainMenu.menuItems.Add("Домашняя работа 1", FillListHomeWork1);
            mainMenu.menuItems.Add("Домашняя работа 2", FillListHomeWork2);
            mainMenu.menuItems.Add("Домашняя работа 3", FillListHomeWork3);
            mainMenu.menuItems.Add("Домашняя работа 4", FillListHomeWork4);
            mainMenu.menuItems.Add("Домашняя работа 5", FillListHomeWork5);
            mainMenu.menuItems.Add("Домашняя работа 6", FillListHomeWork6);
            mainMenu.menuItems.Add("Домашняя работа 7", FillListHomeWork7);
        }
    }
}
