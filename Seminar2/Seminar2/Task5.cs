using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Task5
    {
        static void Main()
        {
            Console.Write("Введите свою массу: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите свой рост в метрах: ");
            double h = double.Parse(Console.ReadLine());
            double i = m / (h * h);
            if (i >= 18.5 && i <= 25)
                Console.WriteLine("У вас нормальная масса!");
            else if (i >= 16 && i < 18.5)
                Console.WriteLine("У вас дефецит массы тела. Вам необходимо набрать: " + Math.Abs(18 - i) + " кг");
            else if (i < 16)
                Console.WriteLine("У вас выраженный дефицит массы тела. Вам необходимо набрать: "+ Math.Abs(18 - i) + " кг");
            else if (i > 25 && i <= 30)
                Console.WriteLine("У вас избыточная масса тела. Вам необходимо сбросить: " + Math.Abs(25 - i) + " кг");
            else if (i > 30 && i <= 35)
                Console.WriteLine("У вас ожирение 1-ой степени. Вам необходимо сбросить: " + Math.Abs(25 - i) + " кг");
            else if (i > 35 && i <= 40)
                Console.WriteLine("У вас ожирение 2-ой степени. Вам необходимо сбросить: " + Math.Abs(25 - i) + " кг");
            else if (i > 40)
                Console.WriteLine("У вас ожирение 3-ой степени. Вам необходимо сбросить: " + Math.Abs(25 - i) + " кг");
        }
    }
}
