using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class MyClass
    {
        public char Symbol;
        public MyClass(char n)
        {
            Symbol = n;
        }
        public static MyClass operator++(MyClass a)
        {
            ++a.Symbol;
            return a;
        }
        public static MyClass operator--(MyClass a)
        {
            --a.Symbol;
            return a;
        }
        public static int operator+(MyClass a, int b)
        {
            int m = a.Symbol + b;            
            return new MyClass((char) m);
        }
        public static int operator +(int b, MyClass a)
        {
            int m = b + a.Symbol;
            return m;
        }
        public static int operator -(MyClass a, MyClass b)
        {
            int m = a.Symbol - b.Symbol;
            return m;
        }
        public override string ToString()
        {
            string Txt = "";
            Txt +="Символьное поле: "+ Symbol;
            return Txt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass('B');
            MyClass B = new MyClass('B');
            ++A;
            --B;
            MyClass C = A + 1;
            int m = 5 - A;
            C = A - B;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("Целочисленное поле: "+C);
            Console.WriteLine("Целочисленное поле: " + C);
            Console.ReadKey();
        }
    }
}
