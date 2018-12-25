using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class MyClass
    {
        public int Number;
        public char Symbol;
        public MyClass(int n, char m)
        {
            Number = n;
            Symbol = m;
        }
        public static bool operator true(MyClass a)
        {
            return a.Number - a.Symbol >= 10;
        }
        public static bool operator false(MyClass a)
        {
            return a.Number - a.Symbol < 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(78, 'A');
            while (A)
            {
                Console.WriteLine(" " + A.Symbol);
                A.Symbol++;
            }
            Console.ReadKey();
        }
    }
}
