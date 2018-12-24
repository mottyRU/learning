using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class MyClass
    {
        public int[] Numbers;
        public MyClass(int Size)
        {
            Numbers = new int[Size];
            for (int i = 0; i > Numbers.Length-1; i++)
            {
                Numbers[i] = 0;
            }
        }
        public static string operator~(MyClass a)
        {
            string Text = "";
            Text += String.Join(", ", a.Numbers);
            //Console.WriteLine(Text);
            return Text;
        }
        public static MyClass operator++(MyClass a)
        {
            Array.Resize(ref a.Numbers, a.Numbers.Length + 1);
            //присвоить значение новому элементиу
            a.Numbers[a.Numbers.Length - 1] = 0;
            return a;
        }
        public static MyClass operator--(MyClass a)
        {
            Array.Resize(ref a.Numbers, a.Numbers.Length - 1);
            return a;
        }
        public static MyClass operator +(MyClass a, MyClass b)
        {
            MyClass c = new MyClass((a.Numbers.Length+b.Numbers.Length));
            a.Numbers.CopyTo(c.Numbers, a.Numbers[0]);
            b.Numbers.CopyTo(c.Numbers, a.Numbers.Length);
            return c;
        }
        public static MyClass operator +(int n, MyClass b)
        {
            MyClass c = new MyClass(b.Numbers.Length + 1);
            b.Numbers.CopyTo(c.Numbers, b.Numbers[1]);
            c.Numbers[0] = 9;
            return c;
        }
        public static MyClass operator +(MyClass a, int m)
        {
            MyClass c = new MyClass(a.Numbers.Length + 1);
            a.Numbers.CopyTo(c.Numbers, a.Numbers[0]);
            c.Numbers[c.Numbers.Length-1] = 9;
            return c;
        }
        public override string ToString()
        {
            string Txt = "Result: ";
            Txt += String.Join(", ", Numbers);
            return Txt;
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass A = new MyClass(5);
            MyClass B = new MyClass(5);
            MyClass C;
            string Z = ~A;
            Console.WriteLine("New Massive: "+Z);
            ++A;
            Console.WriteLine(A);
            --A;
            Console.WriteLine(A);
            for (int i = 0; i < A.Numbers.Length; i++)
            {
                A.Numbers[i] = i;
                B.Numbers[i] = i;
            }
            C = A + B;
            Console.WriteLine(C);
            C = 1 + B;
            Console.WriteLine(C);
            C = A + 5;
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
