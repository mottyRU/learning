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
        public MyClass(int n)
        {
            int Size = n;
            Numbers = new int[Size];
            foreach (int s in Numbers)
            {
                Numbers[s] = 0;
                //Console.Write(Numbers[s]+" ");
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
            Array.Resize(ref a.Numbers, 6);
            string Text = "";
            Text += String.Join(", ", a.Numbers);
            //Console.WriteLine(Text);
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
            int[] c = a.Numbers.Concat(b.Numbers).ToArray();
            /*int[] z = new int[a.Numbers.Length + b.Numbers.Length];
            a.Numbers.CopyTo(z, 0);
            b.Numbers.CopyTo(z, a.Numbers.Length);*/
            Console.WriteLine(String.Join(", ", c));
            return new MyClass(c);
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
            string Z = ~A;
            Console.WriteLine("First: "+Z);
            ++A;
            Console.WriteLine(A);
            --A;
            Console.WriteLine(A);
            MyClass C = A + B;
            C = 1 + B;
            C = A + 5;
            //Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
