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
            if (n.Length != m.Length) return false;
            for (int i = 0; i < n.Length; i++)
            {
                if (Math.Abs(Convert.ToSByte(n[i] - m[i])) > 1) return false;
            }
            return true;
        }
        static void Main()
        {
            string Text_1 = "Hello", Text_2 = "Hello";
            Console.WriteLine("Text 1 == Text 2: {0}", Compare(Text_1, Text_2));
            Console.ReadKey();
        }
    }
}
