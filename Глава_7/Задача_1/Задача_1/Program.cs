using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        public static string Probel(string n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                n.Insert(i, " ");
            }
            return n;
        }
        static void Main()
        {
            string NewText;
            string text = "Hello world!";
            Console.WriteLine("Значение до: " + text);
            Probel(text);
            NewText = Probel(n);
            Console.WriteLine("Значение после: " + m);
            Console.ReadKey();
        }
    }
}
