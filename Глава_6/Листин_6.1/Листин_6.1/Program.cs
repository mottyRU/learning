using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Листин_6._1
{
    class MyClass
    {
        public int number;
        public char symbol;

        public void Show()
        {
            Console.WriteLine("Numbers: " + number);
            Console.WriteLine("Symbols: "+ symbol);
        }
        static void Main()
        {
            MyClass A, B;
            A = new MyClass();
            B = new MyClass();
            A.number = 123456789;
            B.number = 987654321;
            A.symbol = 'B';
            B.symbol = 'A';
            A.Show();
            B.Show();
            Console.ReadKey();
        }
    }
}
