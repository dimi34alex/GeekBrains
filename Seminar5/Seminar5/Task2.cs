using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5
{
    static class Message
    {
        public static void PrintN(int n, string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length <= n)
                    Console.WriteLine(s[i]);
            }
        }
        public static void Delete(char c, string[] s)
        {
            var s1 = new List<string>(s);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i][s.Length-1] == c)
                {
                    s1.RemoveAt(i);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s1[i]);
            }
        }
        public static void MaxMes(string[] s)
        {
            string maxvalue = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > maxvalue.Length)
                {
                    maxvalue = s[i];
                }
            }
            Console.WriteLine(maxvalue);
        }
    }
    class Task2
    {
        static void Main()
        {
            string[] s = { "abc", "abcd", "abcde"};
            //Message.PrintN(4, s);
            //Message.Delete('e', s);
            Message.MaxMes(s);
        }
    }
}
