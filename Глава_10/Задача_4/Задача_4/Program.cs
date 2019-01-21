using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Alpha
    {
        public int Alpha_Number;
        public Alpha(int n)
        {
            Alpha_Number = n;
        }
        public void Prisvoit( int n)
        {
            Alpha_Number = n;
        }
        public override string ToString()
        {
            string Text = "";
            Text += "Alpha class: " + Alpha_Number;
            Text += "\n------------------------------";
            return Text;
        }
    }
    class Betta : Alpha
    {
        public char Betta_Symbol;
        public Betta(int n, char m) : base(n)
        {
            Betta_Symbol = m;
        }
        public void Prisvoit(int n, char m)
        {
            Betta_Symbol = m;
            Alpha_Number = n;
        }
        public override string ToString()
        {
            string Text = "";
            Text += "Alpha class: " + Alpha_Number;
            Text += "\nBetta class: " + Betta_Symbol;
            Text += "\n------------------------------";
            return Text;
        }
    }
    class Gamma : Betta
    {
        public string Gamma_Text;
        public Gamma(int n, char m, string f) : base(n, m)
        {
            Gamma_Text = f;
        }
        public void Prisvoit(int n, char m, string f)
        {
            Betta_Symbol = m;
            Alpha_Number = n;
            Gamma_Text = f;
        }
        public override string ToString()
        {
            string Text = "";
            Text += "Alpha class: " + Alpha_Number;
            Text += "\nBetta class: " + Betta_Symbol;
            Text += "\nGamma class: " + Gamma_Text;
            Text += "\n------------------------------";
            return Text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alpha A = new Alpha(555);
            A.Prisvoit(999);
            Console.WriteLine(A);
            Betta B = new Betta(111, 'Z');
            //B.Prisvoit(222, 'X');
            Console.WriteLine(B);
            Gamma C = new Gamma(000, 'F', "Helllllo!");
            //C.Prisvoit(11111111, 'Y', "Goodbye");
            Console.WriteLine(C); 
            Console.ReadKey();
        }
    }
}
