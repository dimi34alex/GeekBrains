using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string fam = Console.ReadLine();
            Console.Write("Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Рост: ");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + ", " + fam + ", " + age + ", " + hight + ", " + weight);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", name, fam, age, hight, weight);
            Console.WriteLine($"{name}, {fam}, {age}, {hight}, {weight}");
        }
    }
}
