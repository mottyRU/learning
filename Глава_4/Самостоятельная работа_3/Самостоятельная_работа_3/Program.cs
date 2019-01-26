using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symb;
            int size = 10;
            symb = new char[size];
            symb[0] = 'a';
            Console.WriteLine("Massive:");
            Console.WriteLine(""+symb[0]+"");
            for (int i = 1; i<symb.Length; i++)
            {
                symb[i] = (char) (symb[i-1]+2);
                Console.WriteLine(""+symb[i]+"");
            }
            Console.WriteLine("Invert Massive:");
            for (int i = symb.Length-1; i >= 0; i--)
            {
                Console.WriteLine("" + symb[i]+ "");
            }
                Console.ReadKey();
        }
    }
}
