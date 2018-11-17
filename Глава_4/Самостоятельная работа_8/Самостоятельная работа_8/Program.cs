using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows=5, cols=5, A;
            int[,] numb = new int[rows, cols];
            Random rnd = new Random();
            Console.WriteLine("Random massive:");
            for (int i = 0; i < numb.GetLength(0); i++)
            {
                for (int j = 0; j < numb.GetLength(1); j++)
                {
                    numb[i, j] = rnd.Next(1,10);
                    Console.Write(numb[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("New massive:");
            for (int i = 0; i < numb.GetLength(0); i++)
            {
                for (int j = 0; j < numb.GetLength(1); j++)
                {
                    A = j;
                    j = i;
                    i = A;
                    Console.Write(numb[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
