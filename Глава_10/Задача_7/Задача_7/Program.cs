using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Baza
    {
        public string Baza_Text;
        public virtual Alpha Sozdatel()
        {
            Alpha A = new Alpha();
            return A;
        }
    }
    class Alpha : Baza
    {
        public char Alpha_Symbol;
        public override Alpha Sozdatel()
        {
            Alpha A = new Alpha();
            A.Alpha_Symbol = Alpha_Symbol;
            A.Baza_Text = Baza_Text;
            return A;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baza B = new Baza();
            Alpha A = B.Sozdatel();
            A.Baza_Text = "New text";
            A.Alpha_Symbol = 'A';
            Alpha C = A.Sozdatel();
            C.Baza_Text = "Very new text";
            Console.WriteLine(A.Baza_Text + " - " + A.Alpha_Symbol);
            Console.WriteLine(C.Baza_Text + " - " + C.Alpha_Symbol);
            Console.ReadKey();
        }
    }
}
