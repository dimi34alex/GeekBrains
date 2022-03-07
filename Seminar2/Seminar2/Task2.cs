using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task2
    {
        static int Count(string a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count++;
            }
            return count;
        }

        static void Main()
        {
            Console.WriteLine("Введите число:");
            string a = Console.ReadLine();
            Console.WriteLine("Количество цифр в данном числе: "+Count(a));

        }
    }
}