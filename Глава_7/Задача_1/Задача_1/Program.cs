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
            string[] Text2;
            string Hranitel;
            Text2 = n.Split();
            Hranitel = Text2.Join(" ", n);
            return Hranitel;
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
