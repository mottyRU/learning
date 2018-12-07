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
            else
            {
                Max = m;
                Min = n;
            }
        }
        public void Prisvoit(int n)
        {
            Console.WriteLine(""+n+", "+Max+", "+Min+"");
            if (n > Max)
            {
                Max = n;
            }
            else if (n < Min)
            {
                Min = n;
            }
        }
        public void Prisvoit(int n, int m)
        {
            Console.WriteLine("n = {0}, m = {1}, Max = {2}, Min = {3}", n, m, Max, Min);
            MyClass B = new MyClass(n, m);
            B.Prisvoit(n);
            B.Prisvoit(m);
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
            A.Prisvoit(rnd.Next(100), rnd.Next(100));
            A.Show();
            Console.ReadKey();
        }
    }
}
