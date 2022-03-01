using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("Введите массу и рост");
            float m = Convert.ToInt32(Console.ReadLine());
            float h = Convert.ToInt32(Console.ReadLine());
            float i = m / (h * h);
            Console.WriteLine("Индекс массы тела: "+ i);
        }
    }
}
