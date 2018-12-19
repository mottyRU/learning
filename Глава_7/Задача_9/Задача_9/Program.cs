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
        public string[] NewTextMassive(string n, char m)
        {
            string[] NewText = n.Split(m);
            return NewText;
        }
        public override string ToString()
        {
            string Txt = "";
            for (int i = 0; i < NewTextMassive(Text, Symbol).Length; i++)
            {
                Console.WriteLine("\n|"+ NewTextMassive(Text, Symbol)[i]+"|");
            }
            return Txt += "\nOld text: "+Text+"\nSymbol to split: "+Symbol;
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
