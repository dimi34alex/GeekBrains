using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int count = 0;
            int[] a = { };
            a = new int[20];
            for (int i = 0; i <20; i++)
            {
                a[i] = r.Next(-10000,10000);
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i <= a.Length-2; i++)
            {
                if ((a[i] % 3 == 0 && a[i + 1] % 3 != 0) || (a[i] % 3 != 0 && a[i + 1] % 3== 0))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
