using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class MyClass
    {
        private int number;
        
        public void Prisvoit(int n)
        {
            number = n;
        }
        public char Symbol()
        {
            return (char)number;
        }
        public void SymbolAndNumber()
        {
            Console.WriteLine(""+number+","+ Symbol());
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            MyClass B = new MyClass();
            B.Prisvoit(Int32.Parse(Console.ReadLine()));
            B.Symbol();
            B.SymbolAndNumber()
            Console.ReadKey();
        }
    }
}
