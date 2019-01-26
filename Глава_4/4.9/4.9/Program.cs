using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9
{
    class Program
    {
        static void Main(string[] args)
        {
         char[,] symbs;
         symbs = new char[,] { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };
            for (int i = 0; i<symbs.GetLength(0); i++)
            {
                for (int j = 0; j<symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i, j] + " ");
                }
                Console.WriteLine();                    
            }
            Random rnd;
            rnd = new Random();
            int row = rnd.Next(symbs.GetLength(0) + 1);
            int col = rnd.Next(symbs.GetLength(1) + 1);
            Console.WriteLine("Добавляется {0}-я строка и {1}-й столбец", row, col);
            char[,] tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];
            int a, b;
            char s = 'a';
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                if (i < row) a = i;
                else a = i + 1;
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    if (j < col) b = j;
                    else b = j + 1;
                    tmp[a, b] = symbs[i, j];
                }
            }
            for (int j = 0; j < tmp.GetLength(1); j++)
            {
                tmp[row, j] = s;
                s++;
            }
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                if(i!=row)
                {
                    tmp[i, col] = s;
                    s++;
                }
            }
            symbs = tmp;
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
