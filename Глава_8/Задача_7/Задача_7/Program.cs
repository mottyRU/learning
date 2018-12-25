using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        class MyClass
        {
            public string Text;
            public MyClass(string n)
            {
                Text = n;
            }
            public static implicit operator int (MyClass a)
            {
                int TextLenght = a.Text.Length;
                return TextLenght;
            }
            public static implicit operator char (MyClass a)
            {
                char[] NewChar = a.Text.ToCharArray();
                return NewChar[0];
            }
            public static implicit operator MyClass (int n)
            {
                string NewText="";
                for (int i = 0; i != n; i++)
                {
                    NewText += "A";
                }
                MyClass B = new MyClass(NewText);
                return B;
            }

        }
        static void Main(string[] args)
        {
            MyClass A = new MyClass("Hello_Wild_World");
            int a = A;
            Console.WriteLine("A to Int: " + a);
            char b = A;
            Console.WriteLine("A to Char: " + b);
            int n = (MyClass) 5;
            Console.WriteLine("Int to Object: " );
            Console.ReadKey();
        }
    }
}
