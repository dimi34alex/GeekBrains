using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    class Task4
    {
        static void Main()
        {
            Console.WriteLine("Введите две переменные: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine("a = {0} \nb = {1}", a,b);
            //Я не знаю как заменить значения переменных без использования методов и третей переменной,
            //Но, думаю, можно сделать так :)))
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("a = {0} \nb = {1}", b, a);
        }
    }
}
