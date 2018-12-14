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
            string[] Text2 = n.Split();
            string Hranitel = String.Join("", Text2);
            char[] Symbs = Hranitel.ToCharArray();
            Hranitel = String.Join(" ", Symbs);
            return Hranitel;
        }
        static void Main()
        {
            string NewText;
            String text = "Hello wild world!";
            NewText = Probel(text);
            Console.WriteLine("Значение до: " + text);
            Console.WriteLine("Значение после: " + NewText);
            Console.ReadKey();
        }
    }
}
