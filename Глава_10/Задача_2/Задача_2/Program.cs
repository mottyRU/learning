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
        public void Mother_Prisvoit()
        {
            Mother_Text = "Mother_Text_Without_Arguments";
        }
        public void Mother_Prisvoit(string n)
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
    }
    class Dauther : Mother
    {
        public int Dauther_Number;
        public Dauther(int n, string m) : base(m)
        {
            Dauther_Number = n;
        }
        new public void Mother_Prisvoit()
        {
            Dauther_Number = 999;
            //Mother_Text = "Dauther_Text_Without_Arguments";
        }
        public void Dauther_Prisvoit(string n)
        {
            Mother_Text = n;
        }
        public void Dauther_Prisvoit(int n)
        {
            Dauther_Number = n;
        }
        public void Mother_Prisvoit(int n, string m)
        {
            Dauther_Number = n;
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
            Console.WriteLine(B.Dauther_Number);
            Console.ReadKey();
        }
    }
}
