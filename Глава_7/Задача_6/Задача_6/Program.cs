using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        public static int[] IndexSearch(string n, char m)
        {
            int start = 0;
            int at = 0;
            int i = 0;
            int end = n.Length;
            int[] NewMassive = new int[end];
            while (start <= end)
            {
                at = n.IndexOf(m, start);
                if (at == -1) break;
                NewMassive[i] = at;
                i += 1;
                start = at + 1;
            }
            Array.Resize(ref NewMassive, i);
            return NewMassive;
        }
        public static char[] Sortirovka(string n)
        {
            string Hranitel_1 = "";
            char[] Symbols;            
            foreach (char s in n)
            {
                if (!Hranitel_1.Contains(s)) Hranitel_1 += s;
            }
            Symbols = Hranitel_1.Replace(", .", "").ToCharArray();
            //Symbols = Hranitel_1.ToCharArray();
            Array.Sort(Symbols);
            return Symbols;
        }
        static void Main(string[] args)
        {
            string Text = ",A AB.B CC DE";
            Console.WriteLine(Sortirovka(Text));
            Console.ReadKey();
        }
    }
}
