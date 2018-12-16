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
        static void Main()
        {
            string Text = "Hello Wild World";
            char ForSearch = 'l';            
            Console.WriteLine("Array line: ");
            int[] Hranitel = IndexSearch(Text, ForSearch);
            for (int i = 0; i < Hranitel.Length; i++)
            {
                Console.WriteLine(Hranitel);
            }
            Console.ReadKey();
        }
    }
}
