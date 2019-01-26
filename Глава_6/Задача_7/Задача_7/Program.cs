using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class MyClass
    {
        public char Symbol;
        public string Text;
        public void Prisvoit(char n)
        {
            Symbol = n;
        }
        public void Prisvoit(string n)
        {
            Text = n;
        }
        public void Prisvoit(char [] n)
        {
            if (n.Length == 1)
            {
                Symbol = n[0];
            }
            else
            {
                Text = new string (n);
            }
        }
        public void Show()
        {
            Console.WriteLine("" + Text +" " + Symbol);
        }
    }
    class Program
    {
        static void Main()
        {
            char[] TextMassive = new char[2] {'A', 'B'};
            MyClass A = new MyClass();            
            A.Prisvoit(TextMassive);
            A.Show();
            Console.ReadKey();
        }
    }
}
