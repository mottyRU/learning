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
            symb[0] = 'B';
            for (int i=0; i<symb.Length-1; i++)
            {                
                symb[i+1] = (char) (symb[i] + 1);
                if (symb[i]=='D')
                {
                    symb[i+1] = (char)(symb[i] + 2);
                }
                if (symb[i+1] == 'I')
                {
                    symb[i + 1] = (char)(symb[i] + 2);
                }
            }
            foreach (char i in symb)
            {
                Console.Write("" + i + " ");
            }
                       
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
