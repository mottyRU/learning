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
        public string Vstavka(string n, int m)
        {
            return TextPole.Insert(m, n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            A.TextPole = "Hello_Wild_World";
            Console.WriteLine(A.Vstavka("MUR", 11));
            Console.ReadKey();
        }
    }
}
