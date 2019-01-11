using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class MyNewClass
    {
        private char A = 'A';
        private char B = 'Z';
        private char num = 'a';
        public char Symbols
        {
            get
            {
                return num;
            }
            set
            {
                if (value < A) num = A;
                else if (value > B) num = B;
                else num = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyNewClass obj1 = new MyNewClass();
            Console.WriteLine("Значение свойства: " + obj1.Symbols);
            obj1.Symbols = '!';
            Console.WriteLine("Значение свойства: " + obj1.Symbols);
            Console.ReadKey();
        }
    }
}
