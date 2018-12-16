using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {        
        public static char[] Sortirovka(string n)
        {
            string Hranitel_1 = "";
            char[] Symbols;            
            foreach (char s in n)
            {
                if (s == ','| s == '.'|s == ' '| s == '-') continue;
                if (!Hranitel_1.Contains(s)) Hranitel_1 += s;

            }
            Symbols = Hranitel_1.ToCharArray();
            Array.Sort(Symbols);
            return Symbols;
        }
        static void Main(string[] args)
        {
            string Text = ",A AB.B CC-DE";
            Console.WriteLine(Sortirovka(Text));
            Console.ReadKey();
        }
    }
}
