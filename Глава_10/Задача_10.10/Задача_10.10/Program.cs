using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10._10
{
    class Alpha
    {
        protected int[] Numbers = new int[5];
        public int this[int i]
        {
            get
            {
                return Numbers[i];
            }
            set
            {
                Numbers[i] = value;
            }
        }
        public int MassLenght
        {
            get
            {
                return Numbers.Length;
            }
        }
        public override string ToString()
        {
            string Txt = "";
            for (int i = 0; i < Numbers.Length; i++)
            {
                Txt += "|" + Numbers[i];
            }
            Txt += "|";
            return Txt;
        }
    }
    class Bravo : Alpha
    {
        protected char[] Symbols = new char[7];
        int[] AB = new int[2];
        new public char this[int i]
        {
            get
            {
                return Symbols[i];
            }
            set
            {
                Symbols[i] = value;
            }
        }
        new public int[] MassLenght
        {
            get
            {
                AB[0] = Numbers.Length;
                AB[1] = Symbols.Length;
                return AB;
            }
        }
        public override string ToString()
        {
            string Txt = "";
            for (int i = 0; i < Symbols.Length; i++)
            {
                Txt += "|" + Symbols[i];
            }
            Txt += "|";
            return Txt += "\n" + AB[0] + AB[1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Alpha A = new Alpha();
            //Console.WriteLine(A.MassLenght);
            //A[0] = 4;
            //A[4] = 7;
            //Console.WriteLine(A);
            //Console.WriteLine("----------------");
            Bravo B = new Bravo();            
            int[] a = B.MassLenght;
            B[0] = 'S';
            B[6] = 'l';
            Console.WriteLine(B);
            Console.ReadKey();
        }
    }
}
