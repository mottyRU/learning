using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Задача_10
{
    class MyClass
    {
        public int[] Numbers;
        public MyClass()
        {
            Numbers = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(100);
            }
        }
        public override string ToString()
        {
            string Txt = "";
            Txt += "Значения массива: " + String.Join(", ", Numbers);
            Txt += "\nКоличество элементов в массиве: " + Numbers.Length;
            Txt += "\nСреднее значение элементов массива: " + Convert.ToString(Numbers.Sum() / Numbers.Length);
            return Txt;
        }

    }
    class Program
    {
        static void Main()
        {
            MyClass A = new MyClass();
            Thread.Sleep(200);
            MyClass B = new MyClass();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
