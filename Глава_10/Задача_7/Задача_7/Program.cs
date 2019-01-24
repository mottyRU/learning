using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Baza
    {
        public string Baza_Text = "A";
        public virtual Alpha Sozdatel()
        {
            Baza_Text = "Hello";
            Alpha A = new Alpha();
            return A;
        }
    }
    class Alpha : Baza
    {
        public char Alpha_Symbol = 'Z';
        public override Alpha Sozdatel()
        {
            Baza_Text = "Goodbye";
            Alpha A = new Alpha();
            Alpha B = A;
            return B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baza B = new Baza();
            Alpha A = B.Sozdatel();
        }
    }
}
