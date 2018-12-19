using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class MyClass
    {
        public string Text;
        public char Symbol;
        public string[] NewTextMassive()
        {
            string[] NewText = Text.Split(Symbol);
            return NewText;
        }
        public override string ToString()
        {
            string Massive = String.Join(".", NewTextMassive());
            return Massive += "\nPole Text: "+Text+"\nPole Symbol: "+Symbol;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            A.Text = "Hello_Wild_World";
            A.Symbol = '_';
            Console.Write("New text: ");
            Console.WriteLine(A);
            Console.ReadKey();
        }
    }
}
