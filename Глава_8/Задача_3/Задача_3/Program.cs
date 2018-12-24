using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class MyClass
    {
        public int Number1, Number2;
        public MyClass(int n, int m)
        {
            Number1 = n;
            Number2 = m;
        }
        public static bool operator >(MyClass a, MyClass b)
        {
            if ((Math.Pow(a.Number1, 2) + Math.Pow(a.Number2, 2)) > (Math.Pow(b.Number1, 2) + Math.Pow(b.Number2, 2))) return true;
            else return false;
        }
        public static bool operator <(MyClass a, MyClass b)
        {
            if ((Math.Pow(a.Number1, 2) + Math.Pow(a.Number2, 2)) < (Math.Pow(b.Number1, 2) + Math.Pow(b.Number2, 2))) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(7, 8);
            MyClass B = new MyClass(8, 8);
            bool C;
            C = A > B;
            Console.WriteLine("A > B: " + C);
            C = A < B;
            Console.WriteLine("A < B: " + C);
            Console.ReadKey();
        }
    }
}
