using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HelloWorld
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
        //outp += a;
        return outp;

    }
    static void Main()
    {
        Console.Write(Sum(123));
    }
}
