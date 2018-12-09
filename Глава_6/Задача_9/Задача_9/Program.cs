using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        class MyClass
        {
            public static void MethodMaximum(int [] n)
            {
                int index = 0;
                int value = n[index];
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] > value)
                    {
                        value = n[i];
                    }
                }
                Console.WriteLine("Max value is: " +value);
            }
            public static void MethodMinimum(int [] n)
            {
                int index = 0;
                int value = n[index];
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] < value)
                    {
                        value = n[i];
                    }
                }
                Console.WriteLine("Min value is: " + value);
            }
            public static void MethodMediana(int[] n)
            {
                int A, B;
                if (n.Length%2!=0)
                {
                    A = n.Length / 2;
                    B = n[A];
                }
                else
                {
                    A = (n.Length / 2);
                    B = (n[A] + n[A-1]) / 2;
                }
                Console.WriteLine("Mediana value is: " + B);
            }
        }
        static void Main()
        {
            Random rnd = new Random();
            int size = rnd.Next(10);
            int[] Numbers = new int[size];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(20);
                Console.Write("| " + Numbers[i] + " ");
            }
            Console.WriteLine("|");
            Array.Sort(Numbers);
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("| " + Numbers[i] + " ");
            }
            Console.WriteLine("|");
            MyClass.MethodMaximum(Numbers);
            MyClass.MethodMinimum(Numbers);
            MyClass.MethodMediana(Numbers);
            Console.ReadKey();
        }
    }
}
