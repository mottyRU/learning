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
        public static MyClass operator+(MyClass a, int b)
        {
            char m = (char) (a.Symbol + b);            
            return new MyClass(m);
        }
        public static MyClass operator +(int b, MyClass a)
        {
            char m = (char) (b + a.Symbol);
            return new MyClass(m);
        }
        public static MyClass operator -(MyClass a, MyClass b)
        {
            int m = a.Symbol - b.Symbol;
            return new MyClass((char) m);
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
            MyClass A = new MyClass('A');
            MyClass B = new MyClass('Z');
            ++A;
            Console.WriteLine(A);
            --B;
            Console.WriteLine(B);
            MyClass C = A + 1;
            Console.WriteLine(C);
            C = A - B;
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
