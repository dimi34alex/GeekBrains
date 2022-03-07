using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task1
    {
        static int Min(int a, int b, int c)
        {
            if (a > b)
            {
                if (b > c)
                    return c;
                else
                    return b;
            }
            else
            {
                if (a > c)
                    return c;
                else
                    return a;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное число: " + Min(a, b, c));

        }
    }
}
