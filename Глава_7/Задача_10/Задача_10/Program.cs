using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Numbers[i] = rnd.Next(50);
            }
        }
        public override string ToString()
        {
            string Txt = "";
            int Summa = 0;
            foreach (int s in Numbers)
            {
                Summa += s; 
            }
            Txt += "Значения массива: " + String.Join(", ", Numbers);
            Txt += "\nКоличество элементов в массиве: " + Numbers.Length;
            Txt += "\nСреднее значение элементов массива: " + Convert.ToString(Summa / Numbers.Length);
            return Txt;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            MyClass B = new MyClass();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
