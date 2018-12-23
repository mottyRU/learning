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
            for (int i = 0; i > Numbers.Length; i++)
            {
                Numbers[i] = 0;
                //Console.Write(Numbers[i]+" ");
            }
            //Console.WriteLine();
        }

        public MyClass(int[] c)
        {
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
            return a;
        }
        public static MyClass operator--(MyClass a)
        {
            Array.Resize(ref a.Numbers, 4);
            string Text = "";
            Text += String.Join(", ", a.Numbers);
            //Console.WriteLine(Text);
            return a;
        }
        public static MyClass operator +(MyClass a, MyClass b)
        {
            MyClass C = new MyClass(5);
            a.Numbers.CopyTo(C.Numbers, a.Numbers.Length - 1);
            b.Numbers.CopyTo(C.Numbers, b.Numbers.Length - 1);
            //Console.WriteLine(String.Join(", ", c));
            return C;
        }
        public static MyClass operator +(MyClass a, int m)
        {
            int[] result = new int[a.Numbers.Length + 1];
            result[a.Numbers.Length - 1] = m;
            for (int i = a.Numbers.Length-1; i >= 0; i--)
                result[a.Numbers.Length-1] = a.Numbers[i];
            Console.WriteLine("New massive END: " + String.Join(", ", a.Numbers));
            return new MyClass(result);
        }
        public static MyClass operator +(int n, MyClass b)
        {
            int[] result = new int[b.Numbers.Length + 1];
            result[0] = n;
            for (int i = 0; i < b.Numbers.Length; i++)
                result[i + 1] = b.Numbers[i];
            Console.WriteLine("New massive START: " + String.Join(", ", b.Numbers));
            return new MyClass(result);
        }
        public override string ToString()
        {
            string Txt = "Massive: ";
            Txt += String.Join(", ", Numbers);
            Txt += Numbers;
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
            C = A + B;
            C = 1 + B;
            C = A + 5;
            //Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
