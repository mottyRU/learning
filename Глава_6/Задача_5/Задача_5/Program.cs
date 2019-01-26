using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class MyClass
    {
        private int Number;
        public void Prisvoit()
        {
            Number = 0;
        }
        public void Prisvoit(int n)
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
            MyClass A = new MyClass();
            Random rnd = new Random();
            A.Prisvoit();
            A.Show();
            A.Prisvoit(rnd.Next(90, 110));
            A.Show();
            Console.ReadKey();
        }
    }
}
