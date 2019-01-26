using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        public static string Reversed(string n)
        {
            string[] Revers = n.Split();
            Array.Reverse(Revers);
            
            return String.Join(" ", Revers);
        }
        static void Main()
        {
            string Text = "Hello Wild World", NewText;
            NewText = Reversed(Text);
            Console.WriteLine("Текст до: " + Text);
            Console.WriteLine("Текст после: " + NewText);
            Console.ReadKey();
        }
    }
}
