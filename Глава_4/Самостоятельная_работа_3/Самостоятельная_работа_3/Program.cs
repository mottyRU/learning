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
            for (int i = 0; i<symb.Length; i++)
            {
                symb[i] = (char)((int) symb[i]+1);
                Console.WriteLine(""+symb[i]+"");
            }
            Console.ReadKey();
        }
    }
}
