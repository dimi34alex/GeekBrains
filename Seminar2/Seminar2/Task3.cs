using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task3
    {
        static void Main()
        {
            int a = 1;
            int count = 0;
            while (a != 0)
            {
                Console.Write("Введите число: ");
                a = int.Parse(Console.ReadLine());
                
                if (a % 2 == 1)
                {
                    count += 1;
                }
            }
            Console.WriteLine("Количество нечетных чисел: " + count);
        }
    }
}
