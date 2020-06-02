using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CreateListHomeWork listHomeWork = new CreateListHomeWork();
            listHomeWork.OpenMenu();
        }
    }
}
