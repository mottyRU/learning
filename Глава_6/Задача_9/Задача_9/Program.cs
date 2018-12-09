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
            public static void MethodSeredina(int[] n)
            {
                int Summa = n.Sum();
                int index = 0;
                int Mediana = n[index];
                for (int i = 0; i < n.Length; i++)
                {
                    Mediana += n[i];
                    if (Mediana >= Summa / 2)
                    {
                        Mediana = n[i];
                    }
                }
                Console.WriteLine("Mediana value is: " + Mediana);
            }
        }
        static void Main()
        {
            Random rnd = new Random();
            //int size = rnd.Next(5);
            int size = 5;
            int[] Numbers = new int[size];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(20);
                Console.Write("| " + Numbers[i] + " ");
            }
            Console.WriteLine("|");
            //MyClass.MethodMaximum(Numbers);
            //MyClass.MethodMinimum(Numbers);
            MyClass.MethodSeredina(Numbers);
            Console.ReadKey();
        }
    }
}
