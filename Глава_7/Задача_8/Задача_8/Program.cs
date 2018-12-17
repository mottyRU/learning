using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class MyClass
    {
        public string TextPole;
        public void Vstavka(string n, int m)
        {
            TextPole = TextPole.Insert(m, n);
        }
        public override string ToString()
        {
            return TextPole;
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass A = new MyClass();
            A.TextPole = "Hello_Wild_World";
            Console.WriteLine(A.TextPole);
            A.Vstavka("MUR", 11);
            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
