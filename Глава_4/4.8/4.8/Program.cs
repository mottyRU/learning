using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3, cols = 5;
            int[,] number;
            number = new int[rows, cols];
            int value = 1;
            for (int i=0; i<number.GetLength(0); i++)
            {
                for (int j=0; j<number.GetLength(1); j++)
                {
                    number[i, j] = value;
                    value++;
                    Console.Write(number[rows,cols] +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
