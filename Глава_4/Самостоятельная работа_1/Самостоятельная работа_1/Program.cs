using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int[] numbers;
                Console.WriteLine("Enter massive number:");
                numbers = new int[Int32.Parse(Console.ReadLine())];
                Console.WriteLine("Massive of numbers:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i % 5 == 2)
                    {
                        Console.WriteLine("" + i + "");
                    }
                }
            }

            catch
            {
                Console.WriteLine("Error! Enter number!");
            }
            Console.ReadKey();
        }

    }
}
