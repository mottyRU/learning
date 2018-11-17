using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            char[] symb = new char[size];
            symb[0] = 'A';
            Console.WriteLine("Massive:");
            for (int i = 0; i < symb.Length-1; i++)
            {
                symb[i + 1] =(char) (symb[i] + 1);
            }
            foreach (int s in symb)
            {
                Console.Write((char) s + " ");
            }
            char NewSymb;
            for (int i = 0; i < symb.Length-1; i++)
            {
                NewSymb = symb[i];
                symb[i] = symb[symb.Length - 1 - i];
                symb[symb.Length - 1] = NewSymb;
            }
            Console.WriteLine();
            Console.WriteLine("New Massive:");
            foreach (int s in symb)
            {
                Console.Write((char)s + " ");
            }
            Console.ReadKey();
        }
    }
}
