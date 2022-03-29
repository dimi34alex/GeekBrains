using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3
{
    struct Complex
    {
        public override string ToString()
        {
            return $"Результат: {re} + {im}i";
        }

        public int re; public int im;
        public Complex Sum(Complex c1)
        {
            Complex c2;
            c2.re = re + c1.re;
            c2.im = im + c1.im;
            return c2;
        }
        public Complex Raz(Complex c1)
        {
            Complex c2;
            c2.re = re - c1.re;
            c2.im = im - c1.im;
            return c2;
        }
        public Complex Proiz(Complex c1, Complex c2)
        {
            c2.re = re * c1.re - c1.im * c2.im;
            c2.im = c1.re * c2.im + c2.re * c1.im;
            return c2;
        }
        public Complex Del(Complex c1, Complex c2)
        {
            c1.re = (re * c2.re + im * c2.im) / (c2.re * c2.re + c2.im * c2.im);
            c1.im = (c2.re*im - re*c2.im) / (c2.re * c2.re + c2.im * c2.im);
            return c1;
        }
    }
    class Program
    {
        static void Main()
        {
            Complex c1, c2;
            char op;
            Console.WriteLine("Введите действительную часть комплексного числа: ");
            c1.re = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть комплексного числа: ");
            c1.im = int.Parse(Console.ReadLine());

            Console.WriteLine("Знак операции: ");
            op = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите действительную часть комплексного числа: ");
            c2.re = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть комплексного числа: ");
            c2.im = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(c1.Sum(c2));
                    break;
                case '-':
                    Console.WriteLine(c1.Raz(c2));
                    break;
                case '*':
                    Console.WriteLine(c1.Proiz(c1, c2));
                    break;
                case '/':
                    Console.WriteLine(c1.Del(c1, c2));
                    break;
                default:
                    break;
            }
        }
    }
}
