using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Peregruzka
    {
        public char Symbol;
        public Peregruzka(char n)
        {
            Symbol = n;
        }
        public static string operator +(Peregruzka a, Peregruzka b)
        {
            return String.Concat(a.Symbol, b.Symbol); 
        }
        public static int operator -(Peregruzka a, Peregruzka b)
        {
            int NewNumber = a.Symbol - b.Symbol;
            return NewNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Peregruzka A = new Peregruzka('A');
            Peregruzka B = new Peregruzka('Z');
            string Text = A + B;
            Console.WriteLine("Object 1 + Object 2: " + Text);
            int Number = A - B;
            Console.WriteLine("Object 1 ({0}) - Object 2 ({1}): {2}", (int) A.Symbol, (int) B.Symbol, Number);
            Console.ReadKey();
        }
    }
}
