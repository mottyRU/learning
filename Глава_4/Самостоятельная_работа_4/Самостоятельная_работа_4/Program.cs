using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            char[] symb = new char[size];
            Console.WriteLine("Char Massive:");
            symb[0] = 'A';
            for (int i=0; i<symb.Length-1; i++)
            {                
                symb[i+1] = (char) (symb[i] + 1);                             
            }
            foreach (char i in symb)
            {
                Console.Write("" + i + "" + " ");
            }
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
