using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5_через_конструкторы_
{
    class MyClass
    {
        private int Number;
        public MyClass()
        {
            Number = 0;
        }
        public MyClass(int n)
        {
            Console.WriteLine(n);
            if (n > 100)
            {
                Number = 100;
            }
            else
            {
                Number = n;
            }

        }
        public void Show()
        {
            Console.WriteLine(Number);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MyClass A = new MyClass();
            MyClass B = new MyClass(rnd.Next(90, 110));
            A.Show();
            B.Show();
            Console.ReadKey();
        }
    }
}
