using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] numb = new int[size];
            Random rnd = new Random();
            Console.WriteLine("Massive:");
            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = rnd.Next(1, 10);
            }
            foreach (int i in numb)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Sort Massive:");
            int value, index = 0;
            value = numb[index];
            for (int i = 0; i < numb.Length; i++)
            {
                if(numb[i]<value)
                {
                    value = numb[i];
                    index = i;
                }             
            }
            Console.WriteLine("Min number: " + value);
            Console.WriteLine("Index: " + index);
            Console.ReadKey();
        }
    }
}
