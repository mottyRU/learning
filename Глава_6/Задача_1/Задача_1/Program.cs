using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        private int number;
        
        public void Prisvoit()
        {
            Console.WriteLine("Enter number: ");
            number = Int32.Parse(Console.ReadLine());
        }
        public void Symbol()
        {
            
            Console.WriteLine((char) ((int) number));
        }
        public void SymbolAndNumber()
        {
            Console.WriteLine(""+number+","+ (char)((int)number));
        }
    }
    class MyClass
    {
        static void Main()
        {
            Program B = new Program();
            B.Prisvoit();
            B.Symbol();
            B.SymbolAndNumber();
            Console.ReadKey();
        }
    }
}
