using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        public static bool Compare(string n, string m)
        {
            if (n.Length == m.Length)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    int A = Math.Abs(Convert.ToSByte(n[i] - m[i]));
                    if (A > 1) return false;
                    else
                    {
                        Console.WriteLine(Math.Abs(Convert.ToSByte(n[i] - m[i])));
                    }
                }
                return true;
            }
            else return false;
        }
        static void Main()
        {
            string Text_1 = "Hello", Text_2 = "Hello";
            Console.WriteLine("Text 1 == Text 2: {0}", Compare(Text_1, Text_2));
            Console.ReadKey();
        }
    }
}
