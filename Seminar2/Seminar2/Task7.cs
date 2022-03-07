using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task7
    {
        private static int Rek(int a, int b)
        {
            int count = a;
            if (count == b)
            {
                Console.Write(count);
                return 1;
            }
                
            else if (count < b)
            {
                Console.Write(count + " ");
                return Rek(count + 1, b);
            }
            else
            {
                return 0;
            }
        }
        private static int Sum(int a, int b, int sum)
        {
            int count = a;
            if (count == b)
            {
                sum += count;
                return sum;
            }

            else if (count < b)
            {
                sum += count;
                return Sum(count + 1, b, sum);
            }
            else
            {
                return 0;
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите два числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Rek(a, b);Console.WriteLine();
            Console.WriteLine("Сумма этих чисел: " + Sum(a, b, 0));
            
            
            
        }
    }
}
