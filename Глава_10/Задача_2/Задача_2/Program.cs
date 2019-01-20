using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Mother
    {
        protected string Mother_Text;
        public Mother(string n)
        {
            Mother_Text = n;
        }
        public void Prisvoit()
        {
            Mother_Text = "Mother_Text_Without_Arguments";
        }
        public void Prisvoit(string n)
        {
            Mother_Text = n;
        }
        public int Svoistvo
        {
            get
            {
                int TextLength = Mother_Text.Length;
                return TextLength;
            }
        }
        public char this[int i]
        {
            get
            {
                char Symbol;
                Symbol = Mother_Text[i];
                return Symbol;
            }            
        }
        public override string ToString()
        {
            string Text = Mother_Text;
            return Text;
        }
    }
    class Dauther : Mother
    {
        public int Dauther_Number;
        public Dauther(int n, string m) : base(m)
        {
            Dauther_Number = n;
        }
        new public void Prisvoit()
        {
            Dauther_Number = 999;
            Mother_Text = "Dauther_Text_Without_Arguments";
        }
        new public void Prisvoit(string n)
        {
            Mother_Text = n;
        }
        public void Prisvoit(int n)
        {
            Dauther_Number = n;
        }
        public void Prisvoit(int n, string m)
        {
            Dauther_Number = n;
            Mother_Text = m;
        }
        public override string ToString()
        {
            string Text = Mother_Text + "\n" + Dauther_Number;
            return Text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mother A = new Mother("Hello!");
            Console.WriteLine(A.Svoistvo);
            Console.WriteLine(A[0]);
            Dauther B = new Dauther(1, "Goodbye");
            B.Prisvoit();
            //B.Prisvoit(888); 
            Console.WriteLine(B);
            Console.WriteLine(B.Svoistvo);
            Console.WriteLine(B[0]); 
            Console.ReadKey();
        }
    }
}
