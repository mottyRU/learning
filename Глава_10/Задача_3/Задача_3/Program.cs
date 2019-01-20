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
            int[] arr1  = new int[5] { 15, 16, 17, 18, 19 };
            char[] arr2 = new char[3] { 'a', 'b', 'c' };
            Mother Numb_obj = new Mother(arr1);
            Alpha Symb_obj = new Alpha(arr1, arr2);

            arr1[0] = 0;
            arr2[0] = 'z';
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("|", arr1[i]);
            }
            Console.WriteLine("|");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("|", arr2[i]);
            }
            Console.WriteLine("|");
            Console.WriteLine(Numb_obj);
            Console.WriteLine(Symb_obj);
            
            Console.ReadKey(); 
        }
    }
}
