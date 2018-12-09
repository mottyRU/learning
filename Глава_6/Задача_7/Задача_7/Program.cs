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
        char[] TextMassive = new char [2];
        /*public MyClass()
        {
            Random rnd = new Random();
            int size = rnd.Next(1, 5);
            char[] TextMassive = new char[size];
            for (int i = 0; i < TextMassive.Length; i++)
            {
                TextMassive[i] = (char) rnd.Next(100);
            }
        }*/
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
                Text = "" + n;
            }
        }
        public void Show()
        {
            Console.WriteLine("" + Text+" " + Symbol+" " + TextMassive);
        }
    }
    class Program
    {
        static void Main()
        {
            char[] TextMassive = new char[2] {'A', 'B' };
            MyClass A = new MyClass();            
            A.Prisvoit(TextMassive);
            A.Show();
            Console.ReadKey();
        }
    }
}
