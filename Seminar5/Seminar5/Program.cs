using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)'A');
            Console.WriteLine((int)'a');
            Console.WriteLine((int)'0');
            Console.WriteLine((int)'9');
            string login, password;
            Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            password = Console.ReadLine();
            bool flag = true;
            if (login.Length >= 2 && login.Length <= 10 && login[0] >= 'A' && login[0]<= 'z')
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] > '9' || login[i] < 'a')
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag == true)
                Console.WriteLine("Корректный логин и пароль");
            else
                Console.WriteLine("Некорректный логин!");
        }
    }
}
