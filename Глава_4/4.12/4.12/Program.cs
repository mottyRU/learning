using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] number;
            number = new int[2,2,2];
            Console.WriteLine("Massive:");
            for (int i=0; i<number.Length; i++)
            {
                Console.Write("\t"+i+"");
                Console.WriteLine();
                for (int j = 0; j < number.Length; j++)
                {
                    Console.Write("\t" + j + "");
                    for (int k = 0; k < number.Length; k++)
                    {
                        Console.Write("\t" + k + "");

                    }
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
