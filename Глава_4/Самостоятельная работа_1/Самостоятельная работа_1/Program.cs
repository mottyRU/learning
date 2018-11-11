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

                int[] numbers;
            try
            { 
                Console.WriteLine("Enter massive number:");
                numbers = new int[Int32.Parse(Console.ReadLine())];
            }
            catch
            {
                Console.WriteLine("Error! Enter number!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Massive of numbers:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = 5*i+2;
                    Console.WriteLine("" + numbers[i] + "");
                }           
            
            Console.ReadKey();
        }

    }
}
