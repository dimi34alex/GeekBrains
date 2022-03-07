using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task4
    {
        static bool Password(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                if (Password(login, password) == true)
                {
                    Console.WriteLine("Верно!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно! Попробуйте еще раз");
                    Console.WriteLine();
                    i++;
                }
            } while (i < 3);
            if (i == 3)
                Console.WriteLine("Ваш лимит из трех попыток исчерпан!");
        }
    }
}
