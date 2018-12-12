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
            string A;
            for (int i = 0; i < n.Length; i++)
            {
                A = n.Insert(i, " ");
                return A;
            }
            return n;
        }
        static void Main()
        {
            string NewText;
            string text = "Hello world!";
            NewText = Probel(text);
            Console.WriteLine("Значение до: " + text);
            Console.WriteLine("Значение после: " + NewText);
            Console.ReadKey();
        }
    }
}
