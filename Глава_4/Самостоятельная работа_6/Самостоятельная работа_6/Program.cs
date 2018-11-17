using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] numb = new int[size];
            Random rnd = new Random();
            Console.WriteLine("Massive:");
            for (int i = 0; i<numb.Length; i++)
            {
                numb[i] = rnd.Next(1,20);
            }
            foreach (int s in numb)
            {
                Console.Write(s + " ");
            }
            int NewNumber;
            for (int i = 1; i < numb.Length; i++)
            {
                for (int j = 0; j < numb.Length-i; j++)
                {
                    if (numb[j]<numb[j+1])
                    {
                        NewNumber = numb[j + 1];
                        numb[j + 1] = numb[j];
                        numb[j] = NewNumber;
                    }
                }            
            }
            Console.WriteLine();
            Console.WriteLine("Sort Massive:");
            foreach (int s in numb)
            {
                Console.Write(s + " ");
            }
            Console.ReadKey();
        }
    }
}
