using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        public static string Probel(string text)
        {
            string NewText;
            for (int i = 0; i < text.Length; i++)
            {
                text.Insert(i, " ");
            }
            NewText = text;
            Console.WriteLine(NewText);
            return NewText;
        }
        static void Main()
        {
            string text = "Hello world!";
            Console.WriteLine("Значение до: " + text);
            Probel(text);
            //Console.WriteLine("Значение после: " + NewText);
            Console.ReadKey();
        }
    }
}
