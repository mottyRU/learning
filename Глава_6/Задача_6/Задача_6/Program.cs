using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class MyClass
    {
        private int Max, Min;
        public MyClass(int n, int m)
        {
            if (n > m)
            {
                Max = n;
                Min = m;
            }
            else if (m > n)
            {
                Max = m;
                Min = n;
            }
        }
        public void Prisvoit(int n)
        {
            int Hranitel;
            Console.WriteLine(""+n+", "+Max+", "+Min+"");
            if (n > Max)
            {
                Hranitel = Max;
                Max = n;
                n = Hranitel;
            }
            else if (n < Min)
            {
                Hranitel = Min;
                Min = n;
                n = Hranitel;
            }
        }
        public void Show()
        {
            Console.WriteLine(""+Max+", "+Min+"");
        }
    }
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            MyClass A = new MyClass(rnd.Next(100), rnd.Next(100));
            A.Prisvoit(rnd.Next(100));
            A.Show();
            Console.ReadKey();
        }
    }
}
