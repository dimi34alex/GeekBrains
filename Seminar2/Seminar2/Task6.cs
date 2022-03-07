using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task6
    {
        static int Sum(int a)
        {
            string n = a.ToString();
            int outp = 0;
            for (int i = 0; i < n.Length; i++)
            {
                outp += a % 10;
                a /= (int)a;
            }
            outp += a;
            return outp;

        }
        static void Main()
        {
            int count = 0;
            System.DateTime start = DateTime.Now;
            for (int i = 1; i < 1000000; i++) //До шарпа работал в питоне и не знаю есть ли с C# такая особенность:
            { // i считает от 1 до 99999. Нужно ли прибавлять один к миллиону в условии? 
                if (i % Sum(i) == 0)
                {
                    count++;
                }
            }
            System.DateTime finish = DateTime.Now;
            Console.WriteLine("Количество хороших чисел: " + count);
            Console.WriteLine($"Время выполнения программы: {finish - start}");
        }
    }
}
