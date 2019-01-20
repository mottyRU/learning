using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Mother
    {
        public int[] Number;
        public Mother(int[] n)
        {
            Number = n;
        }
        public Mother(Mother A)
        {
            Number = A.Number;            
        }
        public override string ToString()
        {
            string Text = "";
            for (int i = 0; i < Number.Length; i++)
            {
                Text += "|" + Number[i];
            }
            Text += "|";
            return Text;
        }
    }
    class Alpha : Mother
    {
        public char[] Symbols;
        public Alpha(int[] n, char[] m) : base(n)
        {
            Symbols = m;
        }
        public Alpha(Alpha B, Alpha C) : base(B)
        {
            Symbols = C.Symbols;
        }
        public override string ToString()
        {
            string Text = "";
            string Symb = "";
            for (int i = 0; i < Number.Length; i++)
            {
                Text += "|" + Number[i];
            }
            Text += "|";
            for (int i = 0; i < Symbols.Length; i++)
            {
                Symb += "|" + Symbols[i];
            }
            Symb += "|";
            return Text += "\n" + Symb;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mother Numb_obj = new Mother(new int[5] { 15, 16, 17, 18, 19 });
            Mother A;
            A = Numb_obj;
            Console.WriteLine(A);
            Console.WriteLine(Numb_obj);
            Alpha Symb_obj = new Alpha(new int[5] { 19, 18, 17, 16, 15 }, new char[3] { 'a', 'b', 'c' });
            Alpha B;
            Alpha C;
            //B = A.Numb_obj;
            C = Symb_obj;
            Console.WriteLine(C);
            Console.ReadKey(); 
        }
    }
}
