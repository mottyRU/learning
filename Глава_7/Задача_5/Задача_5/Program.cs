using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        public static int[] IndexSearch(string n, char m)
        {
            int start = 0;
            int at = 0;
            int end = n.Length;
            int[] NewMassive = new int[n.Length];
            Console.Write("The string '{0}' occurs at position(s): ", m);
            while (start <= end)
            {
                at = n.IndexOf(m, start);
                if (at == -1) break;
                //Console.Write("{0} ", at);
                NewMassive[n[end-1]] = at;
                end = end - 1;
                start = at + 1;
                Array.Resize(ref NewMassive, at);
            }
            Console.WriteLine();
            return NewMassive;
        }
        static void Main()
        {
            string Text = "Hello Wild World";
            char ForSearch = 'l';            
            Console.WriteLine(IndexSearch(Text, ForSearch));
            Console.ReadKey();
        }
    }
}
