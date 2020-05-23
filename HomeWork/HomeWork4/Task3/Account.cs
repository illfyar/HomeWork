using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.HomeWork4.Task3
{
    struct Account
    {
        string login;
        string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Account(string LogPass)
        {
            string[] vs = LogPass.Split(' ');
            if (vs.Length >= 2)
            {
                login = vs[0];
                password= vs[1];
            }
            else
            {
                login = "";
                password = "";
            }
        }
    }
}
