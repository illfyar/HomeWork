using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;
using Task = Library.Task;
//3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
//    Создайте структуру Account, содержащую Login и Password..
//Ярвимяки Илья

namespace HomeWork.HomeWork4.Task3
{
    class Task3 : Task
    {
        public override string nameTask => "Чтение логинов и паролей в массив ";
        public override string discription => "3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. " +
            "Создайте структуру Account, содержащую Login и Password." +
            "Для завершения задания введите пустой логин нажав Enter";
        int xPosition = 35;
        int yPosition = 15;
        public override void Run()
        {
            RefreshDisplay();
            List<Account> accounts = new List<Account>();
            StreamReader streamReader = new StreamReader("..\\..\\HomeWork4\\Task3\\LoginPassword.txt");
            string line = "";
            string login = "";
            string password = "";
            while ((line = streamReader.ReadLine()) != null )
            {
                Account account = new Account(line);
                accounts.Add(account);
            }
            Account[] arrayAccounts = accounts.ToArray();
            bool accessDenied = true;
            do
            {
                login = ShowInputField("Login: ");
                password = ShowInputField("Password: ");
                Account enteredUser = new Account(login, password);
                IEnumerable<Account> findAccount = arrayAccounts.Where(acc => acc.Equals(enteredUser));
                if (findAccount.Count() > 0)
                {
                    InputConsole.OutputText("Access allowed", xPosition, yPosition);
                    Thread.Sleep(2000);
                    accessDenied = false;
                }
                else
                {
                    InputConsole.OutputText("Access is denied", xPosition, yPosition);
                    Thread.Sleep(2000);
                }
            } while (accessDenied && login != "");
            ExitTask();
        }
        string ShowInputField(string text)
        {
            RefreshDisplay();
            return InputConsole.GetInputText(text, xPosition, yPosition);
        }
        void RefreshDisplay()
        {
            Console.Clear();
            Console.WriteLine(discription);            
        }
    }
}
