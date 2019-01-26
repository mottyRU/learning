using System;
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
            int[,] numb = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
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
            int row = rnd.Next(numb.GetLength(0));
            int col = rnd.Next(numb.GetLength(1));
            Console.WriteLine("Delete {0} row and {1} col", row, col);
            int A, B;
            int[,] NewMassive = new int [numb.GetLength(0)-1, numb.GetLength(1)-1];
            for (int i = 0; i<NewMassive.GetLength(0); i++)
            {
                if (i < row) A = i;
                else A = i+1;
                for (int j = 0; j<NewMassive.GetLength(1); j++)
                {
                    if (j < col) B = j;
                    else B = j+1;
                    NewMassive[i, j] = numb[A, B];
                }
            }
            Console.WriteLine("New Massive:");
            for (int i = 0; i < NewMassive.GetLength(0); i++)
            {
                for (int j = 0; j < NewMassive.GetLength(1); j++)
                {
                    Console.Write(NewMassive[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
