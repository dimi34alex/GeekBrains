using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3
{
    class Task2
    {
        static void Main()
        {
            string a = "";
            int outp = 0;
            int result = 0;
            while (a != "0")
            {
                Console.Write("Введите число (ноль останавливает цикл): ");
                a = Console.ReadLine();
                if (Int32.TryParse(a,out outp) == true )
                {
                    if (outp > 0 && outp % 2 != 0)
                    result += outp;
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            Console.WriteLine(result);
        }
    }
}
