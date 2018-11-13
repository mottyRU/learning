using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int a = 11;
            //Console.WriteLine("Enter massive numbers:");
            //numbers = new int[Int32.Parse(Console.ReadLine())];
            numbers = new int[a];
            //Console.WriteLine("Result is:");
            numbers[0] = 1;
            Console.WriteLine("Массив:");
            Console.WriteLine("" + numbers[0] + "");
            for (int i=1; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i-1]*2;
                
                Console.WriteLine("" + numbers[i] + "");
            }
            Console.WriteLine("Массив в обратном порядке:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("" + numbers[i] + "");
            }
            Console.ReadKey();
        }
    }
}
