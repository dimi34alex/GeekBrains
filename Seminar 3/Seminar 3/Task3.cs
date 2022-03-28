using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3
{
    class fraction
    {
        public int n; int d;
        //public double dec = n/d;

        public int Denom
        {
            get { return d; }
            set { if (d != 0) d = value; else Console.WriteLine("Ошибка! Знаменатель не может равняться нулю!"); }
        }
        public fraction(int n, int d)
        {
            this.n = n;
            this.d = d;
        }
        public fraction()
        {
            int n = 0;
            int d = 1;
        }

        public fraction Sum(fraction f2)
        {
            fraction fout = new fraction(this.n * f2.d + this.d * f2.n, this.d * f2.d);
            return fout; 
        }
        public fraction Diff(fraction f2)
        {
            fraction fout = new fraction(this.n * f2.d - this.d * f2.n, this.d * f2.d);
            return fout;
        }
        public fraction Prod(fraction f2)
        {
            fraction fout = new fraction(this.n * f2.n, this.d * f2.d);
            return fout;
        }
        public fraction Chas(fraction f2)
        {
            fraction fout = new fraction(this.n * f2.d, this.d * f2.n);
            return fout;
        }
        public override string ToString()
        {
            int i = 2;
            while (i < n || i < d)
            {
                while (n % i == 0 && d % i == 0)
                {
                    n /= i;
                    d /= i;
                    i = 2;
                }
                i++;
            }
            
            return $"{n}/{d}";
        }
    }

    class Task3
    {
        static void Main() {
            Console.Write("Введите первую дробь через слеш: ");
            string drob = Console.ReadLine().Replace(" ", "");
            int n = int.Parse(drob.Split('/')[0]);
            int d = int.Parse(drob.Split('/')[1]);
            fraction f1 = new fraction(n,d);

            Console.Write("Введите вторую дробь через слеш: ");
            drob = Console.ReadLine().Replace(" ", "");
            n = int.Parse(drob.Split('/')[0]);
            d = int.Parse(drob.Split('/')[1]);
            fraction f2 = new fraction(n, d);

            Console.Write($"Их сумма: {f1.Sum(f2)} \n");
            Console.Write($"Их разность: {f1.Diff(f2)} \n");
            Console.Write($"Их произведение: {f1.Prod(f2)} \n");
            Console.Write($"Их частное: {f1.Chas(f2)} \n");
        }
    }
}
