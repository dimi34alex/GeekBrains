using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Seminar4
{
    static class StaticClass
    {
        static int Pari(int[] a)
        {
            int count = 0;
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if ((a[i] % 3 == 0 && a[i + 1] % 3 != 0) || (a[i] % 3 != 0 && a[i + 1] % 3 == 0))
                    count++;
            }
            return count;
        }
        static int[] Fromtxt(string path, int n)
        {
            int[] error = new int[0];
            try
            {
                StreamReader sr = new StreamReader(path);
                int[] ar = new int[n];
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = int.Parse(sr.ReadLine());
                }
                return ar;
            }
            catch
            {
                Console.WriteLine("Не найден файл на диске!");
                return error;
            }
        }
    }
    class Task2
    {
        static void Main()
        {
            
        }
    }
}
