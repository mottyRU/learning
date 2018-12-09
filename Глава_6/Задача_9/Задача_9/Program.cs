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
            public MyClass (int[] n)
            {
                int Hranitel;
                for (int i = 1; i < n.Length; i++)
                {
                    for (int j = 0; j < n.Length - 1; j++)
                    {
                        if (n[j] > n[j + 1])
                        {
                            Hranitel = n[j + 1];
                            n[j + 1] = n[j];
                            n[j] = Hranitel;
                        }
                    }
                }
                for (int i = 0; i < n.Length; i++)
                {
                    Console.Write("| " + n[i] + " ");
                }
                Console.WriteLine("|");
            }
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
                    Console.WriteLine("Mediana value is: " + B);
                }
                else
                {
                    A = (n.Length / 2);
                    B = A + (A - 1) / 2;
                    Console.WriteLine("Mediana value is: " + B);
                }
            }
        }
        static void Main()
        {
            Random rnd = new Random();
            //int size = rnd.Next(10);
            int size = 6;
            int[] Numbers = new int[size];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(20);
                Console.Write("| " + Numbers[i] + " ");
            }
            Console.WriteLine("|");
            MyClass A = new MyClass(Numbers);
            //MyClass.MethodMaximum(Numbers);
            //MyClass.MethodMinimum(Numbers);
            MyClass.MethodMediana(Numbers);
            Console.ReadKey();
        }
    }
}
