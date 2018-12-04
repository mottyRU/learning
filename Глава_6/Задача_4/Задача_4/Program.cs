using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class MyClass
    {
        public char Symbol;
        public int Number;
        public MyClass(char N, int M)
        {
            Symbol = N;
            Number = M;
        }
        public MyClass(double K)
        {
            string Text;
            Text = Convert.ToString(K);
            Symbol = Text[0];
            Number = Text[Text.Length-1];
            
        }
        public void Show()
        {
            Console.WriteLine("" + Symbol + ", " + Number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass('A', 55);
            A.Show();
            MyClass B = new MyClass(65.12);
            B.Show();
            Console.ReadKey();            
        }
    }
}
