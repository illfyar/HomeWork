using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Task
    {
        public virtual string nameTask { get; }
        public virtual string discription { get; }
        virtual public void Run() { }
        protected void ExitTask()
        {
            int answUser = Parse.StringToInt(InputConsole.GetInputText("Повторить выполнение (1): "));
            if (answUser == 1) Run();
        }
    } 
}
