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
            int size = 10; ;
            char[] symb = new char[size];
            Console.WriteLine("Char Massive:");
            for (int i=0; i<symb.Length-1; i++)
            {
                symb[0] = 'A';
                symb[i+1] = (char) ((int)symb[i] + 1);
                Console.Write("" + symb[i] + ""+" ");
                
            }
            Console.WriteLine();
            switch(symb[size])
            {
                case 'A':
                    break;
                case 'B':
                    Console.Write("B" + " ");
                    break;
                case 'C':
                    Console.Write("C" + " ");
                    break;
                case 'D':
                    Console.Write("D" + " ");
                    break;
                case 'E':
                    break;
                case 'F':
                    Console.Write("F" + " ");
                    break;
                case 'G':
                    Console.Write("G" + " ");
                    break;
                case 'H':
                    Console.Write("H" + " ");
                    break;
                case 'I':
                    break;
            }
            Console.ReadKey();
        }
    }
}
