using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using HomeWork.HomeWork5;
using HomeWork.HomeWork5.Task2;

namespace HomeWork
{
    public partial class CreateListHomeWork
    {
        public void FillListHomeWork5()
        {
            taskMenu.menuItems.Clear();
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            taskMenu.menuItems.Add(task1.nameTask, task1.Run);
            taskMenu.menuItems.Add(task2.nameTask, task2.Run);
            taskMenu.menuItems.Add(task3.nameTask, task3.Run);
            taskMenu.OpenMenu("");
        }
    }
}
