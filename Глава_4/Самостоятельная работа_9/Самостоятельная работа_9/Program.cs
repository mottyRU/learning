﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numb = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Massive:");
            for (int i = 0; i < numb.GetLength(0); i++)
            {
                for (int j = 0; j < numb.GetLength(1); j++)
                {
                    Console.Write(numb[i, j] + "\t");
                }
                Console.WriteLine();
            }            
            Random rnd = new Random();
            int row = rnd.Next(numb.GetLength(0) - 1);
            int col = rnd.Next(numb.GetLength(1) - 1);
            Console.WriteLine("Delete {0} row and {1} col", row, col);
            int A, B;
            int[,] NewMassive = new int [rnd.Next(numb.GetLength(0) - 1), rnd.Next(numb.GetLength(1) - 1)];
            for (int i = 0; i<numb.GetLength(0); i++)
            {
                if (i > row) A = i;
                else A = i - 1;
                for (int j=0; j<numb.GetLength(1);i++)
                {
                    if (j > col) B = j;
                    else B = j - 1;
                    numb[A, B] = numb[i, j];
                }
            }
            Console.WriteLine("New Massive:");
            for (int i = 0; i < numb.GetLength(0); i++)
            {
                for (int j = 0; j < numb.GetLength(1); j++)
                {
                    Console.Write(numb[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
