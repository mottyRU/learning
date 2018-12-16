using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        public static int IndexSearch(string n, char m)
        {
            int start;
            int at = 0;
            int end;
            int count = 0;
            end = n.Length;
            start = 0;
            Console.Write("The string 'l' occurs at position(s): ");
            while ((start <= end) && (at > -1))
            {
                count = end - start;
                at = n.IndexOf("l", start, count);
                if (at == -1) break;
                Console.Write("{0} ", at);
                start = at + 1;
            }
            Console.WriteLine();
            return at;
        }
        static void Main()
        {
            string Text = "Hello Wild World";
            char ForSearch = 'W';            
            IndexSearch(Text, ForSearch);
            Console.ReadKey();
        }
    }
}
